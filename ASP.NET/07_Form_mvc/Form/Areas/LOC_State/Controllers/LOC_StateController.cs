using Form.Areas.LOC_Contry.Models;
using Form.Areas.LOC_State.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Form.Areas.LOC_State.Controllers
{
    [Area("LOC_State")]
    public class LOC_StateController : Controller
    {
        private readonly IConfiguration _configuration;
        public LOC_StateController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult StateList()
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_State_SelectAll";
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

        public IActionResult AddState(int? StateID)
        {
            LOC_StateModel LS = new LOC_StateModel();
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Country_SelectAll";
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                List<Dictionary<String,dynamic>> Countrys= new List<Dictionary<String, dynamic>>();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    Dictionary<String,dynamic> Country = new Dictionary<String,dynamic>();
                    Country.Add("CountryName", (string)row["CountryName"]);
                    Country.Add("CountryID", (int)row["CountryID"]);
                    Countrys.Add(Country);
                };
                LS.Countrys = Countrys;

                if (StateID != null)
                {
                    ViewBag.Data = "For Edit";
                    DataTable dt2 = new DataTable();
                    objCmd.CommandText = "PR_State_SelectByPK";
                        objCmd.Parameters.AddWithValue("@StateID", StateID);
                        SqlDataReader objDataReader2 = objCmd.ExecuteReader();
                        dt2.Load(objDataReader2);
                        conn.Close();
                    LS.StateID = (int)dt2.Rows[0]["StateID"];
                        LS.StateName = (string)dt2.Rows[0]["StateName"];
                        LS.StateCode = (string)dt2.Rows[0]["StateCode"];
                        LS.CountryID = (int)dt2.Rows[0]["CountryID"];
                }
                else
                {
                    ViewBag.Data = "For Add";
                }
            }
            catch (Exception ex)
            {
               
            }
           
            return View(LS);
        }

        public IActionResult Save(LOC_StateModel StateModel)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (StateModel.StateID != null)
                {
                    objCmd.CommandText = "PR_State_UpdateByPK";
                    objCmd.Parameters.AddWithValue("@StateID", StateModel.StateID);
                }
                else
                {
                    objCmd.CommandText = "PR_State_Insert";
                }
                objCmd.Parameters.AddWithValue("@StateName", StateModel.StateName);
                objCmd.Parameters.AddWithValue("@StateCode", StateModel.StateCode);
                objCmd.Parameters.AddWithValue("@CountryID", StateModel.CountryID);

                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("StateList");
            }
        }
        public IActionResult DeleteState(int StateID)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_State_DeleteByPK";
                objCmd.Parameters.AddWithValue("@StateID", StateID);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("StateList");
            }
        }

        public IActionResult StateSearch(String? StateName, string? StateCode)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_State_Search";
                objCmd.Parameters.AddWithValue("@StateName", StateName);
                objCmd.Parameters.AddWithValue("@StateCode", StateCode);
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                conn.Close();

                return View("StateList", dt);
            }
            catch (Exception ex)
            {
                return View("StateList");
            }
        }

    }
}
