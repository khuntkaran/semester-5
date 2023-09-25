using Form.Areas.MST_Student.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Form.Areas.MST_Student.Controllers
{
    [Area("MST_Student")]
    public class MST_StudentController : Controller
    {
        private readonly IConfiguration _configuration;
        public MST_StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult StudentList()
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Student_SelectAll";
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                conn.Close();

                return View(dt);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult AddStudent(int? StudentID)
        {
            MST_StudentModel sm = new MST_StudentModel();
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Branch_SelectAll";
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                List<Branch> branches = new List<Branch>();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    Branch br = new Branch();
                    br.BranchName = (string)row["BranchName"];
                    br.BranchID = (int)row["BranchID"];
                    branches.Add(br);
                };
                sm.Branches = branches;

                DataTable dt2 = new DataTable();
                SqlCommand objcmd2 =  conn.CreateCommand();
                objcmd2.CommandType = CommandType.StoredProcedure;
                objcmd2.CommandText = "PR_City_SelectAll";
                SqlDataReader reader2 = objcmd2.ExecuteReader();
                dt2.Load(reader2);
                List<City> citys = new List<City>(); 
                foreach(DataRow dr in dt2.Rows)
                {
                    City city = new City();
                    city.CityID = (int)dr["CityID"];
                    city.CityName = (string)dr["CityName"];
                    citys.Add(city);
                }
                sm.cities = citys;
                if (StudentID != null)
                {
                    ViewBag.Data = "For Edit";
                    DataTable dt3 = new DataTable();
                    SqlCommand objcmd3 = conn.CreateCommand();
                    objcmd3.CommandType = CommandType.StoredProcedure;
                    objcmd3.CommandText = "PR_Student_SelectByPK";
                    objcmd3.Parameters.AddWithValue("@StudentID", StudentID);
                    SqlDataReader reader3 = objcmd3.ExecuteReader();
                    dt3.Load(reader3);
                    sm.StudentName = (string)dt3.Rows[0]["StudentName"];
                    sm.Email = (string)dt3.Rows[0]["Email"];
                    sm.Address = (string)dt3.Rows[0]["Address"];
                    sm.Age = (int)dt3.Rows[0]["Age"];
                    sm.MobileNoFather = (string)dt3.Rows[0]["MobileNoFather"];
                    sm.MobileNoStudent = (string)dt3.Rows[0]["MobileNoStudent"];
                    sm.Gender = (string)dt3.Rows[0]["Gender"];
                    sm.BirthDate = (DateTime)dt3.Rows[0]["BirthDate"];
                    sm.IsActive = (bool)dt3.Rows[0]["IsActive"];
                    sm.Password = (string)dt3.Rows[0]["Password"];
                    sm.CityID = (int)dt3.Rows[0]["CityID"];
                    sm.BranchID = (int)dt3.Rows[0]["BranchID"];
                    conn.Close();
                    return View(sm);
                }
                else
                {
                    ViewBag.Data = "For Add";
                    return View(sm);
                }
            }
            catch(Exception e)
            {
                return View();
            }
            
            
        }
        public IActionResult Save(MST_StudentModel studentModel)
        {
            try
            {
                string connstr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand objcmd = conn.CreateCommand();
                objcmd.CommandType = CommandType.StoredProcedure;
                if(studentModel.StudentID != null)
                {
                    objcmd.CommandText = "PR_Student_UpdateByPK";
                    objcmd.Parameters.AddWithValue("@StudentID", studentModel.StudentID);
                }
                else
                {
                    objcmd.CommandText = "PR_Student_Insert";
                }
                objcmd.Parameters.AddWithValue("@StudentName", studentModel.StudentName);
                objcmd.Parameters.AddWithValue("@BranchID", studentModel.BranchID);
                objcmd.Parameters.AddWithValue("@CityID", studentModel.CityID);
                objcmd.Parameters.AddWithValue("@MobileNoFather", studentModel.MobileNoFather);
                objcmd.Parameters.AddWithValue("@MobileNoStudent", studentModel.MobileNoStudent);
                objcmd.Parameters.AddWithValue("@Age", studentModel.Age);
                objcmd.Parameters.AddWithValue("@BirthDate", studentModel.BirthDate);
                objcmd.Parameters.AddWithValue("@Email", studentModel.Email);
                objcmd.Parameters.AddWithValue("@Address", studentModel.Address);
                objcmd.Parameters.AddWithValue("@Gender", studentModel.Gender);
                objcmd.Parameters.AddWithValue("@IsActive", studentModel.IsActive);
                objcmd.Parameters.AddWithValue("@Password", studentModel.Password);
                objcmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return RedirectToAction("StudentList");
        }

        public IActionResult DeleteStudent(int StudentID)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Student_DeleteByPK";
                objCmd.Parameters.AddWithValue("@StudentID", StudentID);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("StudentList");
            }
        }

        public IActionResult StudentSearch(String? StudentName, string? BranchName)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Student_Search";
                objCmd.Parameters.AddWithValue("@StudentName", StudentName);
                objCmd.Parameters.AddWithValue("@BranchName", BranchName);
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                conn.Close();

                return View("StudentList", dt);
            }
            catch (Exception ex)
            {
                return View("StudentList");
            }
        }

        public IActionResult StudentDetail(int StudentID)
        {
            DataTable dt = new DataTable();
            String connectionStr = this._configuration.GetConnectionString("myConnectionString");
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();
            SqlCommand objcmd3 = conn.CreateCommand();
            objcmd3.CommandType = CommandType.StoredProcedure;
            objcmd3.CommandText = "PR_Student_SelectByPK";
            objcmd3.Parameters.AddWithValue("@StudentID", StudentID);
            SqlDataReader reader3 = objcmd3.ExecuteReader();
            dt.Load(reader3);
            conn.Close();
            return View(dt.Rows[0]);
        }


    }
}
