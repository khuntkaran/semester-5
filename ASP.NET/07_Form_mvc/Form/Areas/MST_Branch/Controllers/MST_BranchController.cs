using Form.Areas.LOC_Contry.Models;
using Form.Areas.MST_Branch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Form.Areas.MST_Branch.Controllers
{
    [Area("MST_Branch")]
    public class MST_BranchController : Controller
    {
        private readonly IConfiguration _configuration;
        public MST_BranchController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult BranchList()
        {
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
                conn.Close();

                return View(dt);
            }
            catch (Exception ex)
            {
                return View();
            }

        }

        public IActionResult AddBranch(int? BranchID)
        {
            if (BranchID != null)
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
                    objCmd.CommandText = "PR_Branch_SelectByPK";
                    objCmd.Parameters.AddWithValue("@BranchID", BranchID);
                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    dt.Load(objDataReader);
                    conn.Close();
                    MST_BranchModel MB = new MST_BranchModel
                    {
                        BranchID = (int)dt.Rows[0]["BranchID"],
                        BranchName = (string)dt.Rows[0]["BranchName"],
                        BranchCode = (string)dt.Rows[0]["BranchCode"]
                    };
                    return View(MB);
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
        public IActionResult Save(MST_BranchModel branchModel)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (branchModel.BranchID != null)
                {
                    objCmd.CommandText = "PR_Branch_UpdateByPK";
                    objCmd.Parameters.AddWithValue("@BranchID", branchModel.BranchID);
                }
                else
                {
                    objCmd.CommandText = "PR_Branch_Insert";
                }
                objCmd.Parameters.AddWithValue("@BranchName", branchModel.BranchName);
                objCmd.Parameters.AddWithValue("@BranchCode", branchModel.BranchCode);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("BranchList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("BranchList");
            }
        }
        public IActionResult DeleteBranch(int BranchID)
        {
            try
            {
                String connectionStr = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection conn = new SqlConnection(connectionStr);
                conn.Open();
                SqlCommand objCmd = conn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "PR_Branch_DeleteByPK";
                objCmd.Parameters.AddWithValue("@BranchID", BranchID);
                objCmd.ExecuteReader();
                conn.Close();
                return RedirectToAction("BranchList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("BranchList");
            }
        }
    }
}
