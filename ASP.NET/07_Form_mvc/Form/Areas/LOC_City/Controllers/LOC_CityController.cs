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


        public IActionResult Save(LOC_CityModel city)
        {
            return RedirectToAction("CityList");
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

        public void SetState(int CountryID)
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
                objCmd.CommandText = "PR_State_SelectByFK";
                objCmd.Parameters.AddWithValue("CountryID", @CountryID);
                SqlDataReader objDataReader = objCmd.ExecuteReader();
                dt.Load(objDataReader);
                List<StateDropDown> States = new List<StateDropDown>();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    StateDropDown State = new StateDropDown();
                    State.StateName = (string)row["StateName"];
                    State.StateID = (int)row["StateID"];
                    States.Add(State);
                };
                LC.StateDrops = States;
            }
            catch (Exception ex)
            {

            }

        }
    }
}
