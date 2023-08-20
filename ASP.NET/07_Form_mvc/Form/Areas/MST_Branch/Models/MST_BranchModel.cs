using System.ComponentModel.DataAnnotations;

namespace Form.Areas.MST_Branch.Models
{
    public class MST_BranchModel
    {
        public int? BranchID { get; set; }
        [Required]
        public string BranchName { get; set; }

        [Required]
        public string BranchCode { get; set; }
    }
}
