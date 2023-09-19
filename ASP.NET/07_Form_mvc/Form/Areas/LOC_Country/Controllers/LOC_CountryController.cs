using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Form.Areas.LOC_Contry.Models;

namespace Form.Areas.LOC_Contry.Controllers
{
    [Area("LOC_Country")]
    public class LOC_CountryController : Controller
    {
        private readonly IConfiguration _configuration;
        public LOC_CountryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult CountryList()
        {
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
                conn.Close();
                
                return View(dt);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        public IActionResult AddCountry(int? CountryID)
        {
            if(CountryID != null)
            {
                ViewBag.Data = "For Edit";
                try
                {
                    String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                    DataTable dt = new DataTable();
                    SqlConnection conn = new SqlConnection(connectionStr);
                    conn.Open();
                    SqlCommand objCmd = conn.CreateCommand();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = "PR_Country_SelectByPK";
                    objCmd.Parameters.AddWithValue("@CountryID", CountryID);
                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    dt.Load(objDataReader);
                    conn.Close();
                    LOC_CountryModel LC = new LOC_CountryModel {
                        CountryID= (int)dt.Rows[0]["CountryID"],
                        CountryName= (string)dt.Rows[0]["CountryName"],
                        CountryCode = (string)dt.Rows[0]["CountryCode"]
                };
                    return View(LC);
                }
                catch (Exception ex)
                {
                    return View();
                }
                
            }
            else
            {
                ViewBag.Data = "For Add";
                return View();
            }
            
        }

        public IActionResult Save(LOC_CountryModel CountryModel)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (CountryModel.CountryID != null)
                { 
                    objCmd.CommandText = "PR_Country_UpdateByPK";
                    objCmd.Parameters.AddWithValue("@CountryID", CountryModel.CountryID);
                }
                else
                {
                    objCmd.CommandText = "PR_Country_Insert";  
                }
                objCmd.Parameters.AddWithValue("@CountryName", CountryModel.CountryName);
                objCmd.Parameters.AddWithValue("@CountryCode", CountryModel.CountryCode);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("CountryList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("CountryList");
            }
        }

        public IActionResult DeleteCountry(int CountryID)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Country_DeleteByPK";
                objCmd.Parameters.AddWithValue("@CountryID", CountryID);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("CountryList");
            }
            catch(Exception ex)
            {
                return RedirectToAction("CountryList");
            }
        }

        public IActionResult CountrySearch(String? CountryName,string? CountryCode)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Country_Search";
                objCmd.Parameters.AddWithValue("@CountryName", CountryName);
                objCmd.Parameters.AddWithValue("@CountryCode", CountryCode);
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                conn.Close();

                return View("CountryList",dt);
            }
            catch (Exception ex)
            {
                return View("CountryList");
            }
        }
    }
}
