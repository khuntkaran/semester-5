using Form.Areas.LOC_City.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Form.Areas.LOC_City.Controllers
{
    [Area("LOC_City")]
    public class LOC_CityController : Controller
    {
        private readonly IConfiguration _configuration;
        public LOC_CityController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult CityList()
        {
            try
            {
                String connectionstr = this._configuration.GetConnectionString("myConnectionString");
                DataTable Dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionstr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PR_City_SelectAll";
                SqlDataReader reader = cmd.ExecuteReader();
                Dt.Load(reader);
                conn.Close();
                return View(Dt);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult AddCity(int? CityID)
        {
            LOC_CityModel LC = new LOC_CityModel();
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
                List<CountryDropDown> Countrys = new List<CountryDropDown>();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    CountryDropDown Country = new CountryDropDown();
                    Country.CountryName = (string)row["CountryName"];
                    Country.CountryID = (int)row["CountryID"];
                    Countrys.Add(Country);
                };
                LC.CountryDrops = Countrys;


                DataTable dt3 = new DataTable();
                SqlCommand objCmd3 = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_State_SelectAll";
                SqlDataReader objDataReader3 = objCmd.ExecuteReader();
                dt3.Load(objDataReader3);
                List<StateDropDown> States = new List<StateDropDown>();
                foreach (System.Data.DataRow row in dt3.Rows)
                {
                    StateDropDown State = new StateDropDown();
                    State.StateName = (string)row["StateName"];
                    State.StateID = (int)row["StateID"];
                    States.Add(State);
                };
                LC.StateDrops = States;
                if (CityID != null)
                {
                    ViewBag.Data = "For Edit";

                    DataTable dt2 = new DataTable();
                    SqlCommand objcmd2 = conn.CreateCommand();
                    objcmd2.CommandType = CommandType.StoredProcedure;
                    objcmd2.CommandText = "PR_City_SelectByPK";
                    objcmd2.Parameters.AddWithValue("@CityID", CityID);
                    SqlDataReader objdatareder2 = objcmd2.ExecuteReader();
                    dt2.Load(objdatareder2);
                    conn.Close();
                    LC.CityID = (int?)dt2.Rows[0]["CityID"];
                    LC.CityName = (string)dt2.Rows[0]["CityName"];
                    LC.CityCode = (string)dt2.Rows[0]["CityCode"];
                    LC.CountryID = (int)dt2.Rows[0]["CountryID"];
                    LC.StateID = (int)dt2.Rows[0]["StateID"];
                }
                else
                {
                    ViewBag.Data = "For Add";
                }
            }
            catch (Exception ex)
            {
            }

            return View(LC);
        }


        public IActionResult Save(LOC_CityModel cityModel)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (cityModel.CityID != null)
                {
                    objCmd.CommandText = "PR_City_UpdateByPK";
                    objCmd.Parameters.AddWithValue("@CityID", cityModel.CityID);
                }
                else
                {
                    objCmd.CommandText = "PR_City_Insert";
                }
                objCmd.Parameters.AddWithValue("@CountryID",cityModel.CountryID);
                objCmd.Parameters.AddWithValue("@StateID",cityModel.StateID);
                objCmd.Parameters.AddWithValue("@CityName", cityModel.CityName);
                objCmd.Parameters.AddWithValue("@CityCode", cityModel.CityCode);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("CityList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("CityList");
            }

        }

        public IActionResult DeleteCity(int CityID)
        {
            try
            {
                String connectionstr = this._configuration.GetConnectionString("myConnectionString");
                DataTable Dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionstr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PR_City_DeleteByPK";
                cmd.Parameters.AddWithValue("CityID", CityID);
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("CityList");
        }

        #region DropDownByCountry
        public IActionResult DropDownByCountry(int CountryID)
        {
            string connectionstr = this._configuration.GetConnectionString("myConnectionString");
            SqlConnection conn = new SqlConnection(connectionstr);
            conn.Open();
            SqlCommand objcmd = conn.CreateCommand();
            objcmd.CommandType = System.Data.CommandType.StoredProcedure;
            objcmd.CommandText = "PR_State_SelectByFK";
            objcmd.Parameters.AddWithValue("@CountryID", CountryID);
            DataTable dt = new DataTable();
            SqlDataReader objSDR = objcmd.ExecuteReader();
            dt.Load(objSDR);
            conn.Close();

            List<StateDropDown> States = new List<StateDropDown>();
            foreach (DataRow dr in dt.Rows)
            {
                StateDropDown state = new StateDropDown();
                state.StateID = Convert.ToInt32(dr["StateID"]);
                state.StateName = dr["StateName"].ToString();
                States.Add(state);
            }
            var State = States;
            return Json(State);
        }
        #endregion

        public IActionResult CitySearch(String? CityName, string? CityCode)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_City_Search";
                objCmd.Parameters.AddWithValue("@CityName", CityName);
                objCmd.Parameters.AddWithValue("@CityCode", CityCode);
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                conn.Close();

                return View("CityList", dt);
            }
            catch (Exception ex)
            {
                return View("CityList");
            }
        }

    }
}
