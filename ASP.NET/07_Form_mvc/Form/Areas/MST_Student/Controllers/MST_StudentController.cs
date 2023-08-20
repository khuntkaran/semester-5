using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.Data.SqlClient;
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
            if(StudentID != null)
            {
                ViewBag.Data = StudentID;
            }
            else
            {
                ViewBag.Data = -1;
            }
            return View();
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
    }
}
