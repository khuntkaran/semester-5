using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Form.Areas.LOC_City.Controllers
{
    [Area("LOC_City")]
    public class LOC_CityController : Controller
    {
        private readonly IConfiguration _configuration;
        public LOC_CityController(IConfiguration configuration){
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
            catch(Exception ex)
            {
                return View();
            }
        }
        
        public IActionResult AddCity(int? CityID)
        {
            if(CityID != null)
            {
                ViewBag.Data=CityID;
            }
            else
            {
                ViewBag.Data=-1;
            }
            return View();
        }

        public IActionResult DeleteCity(int CityID)
        {
            try
            {
                String connectionstr = this._configuration.GetConnectionString("myConnectionString");
                DataTable Dt =new DataTable();
                SqlConnection conn = new SqlConnection(connectionstr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.CommandText = "PR_City_DeleteByPK";
                cmd.Parameters.AddWithValue("CityID", CityID);
                cmd.ExecuteReader();
                conn.Close();
            }
            catch(Exception ex)
            {

            }
            return RedirectToAction("CityList");
        }
    }
}
