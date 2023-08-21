using Microsoft.Build.Framework;

namespace Form.Areas.MST_Student.Models
{
    public class MST_StudentModel
    {
        public int? StudentID { get; set; }

        [Required]
        public string StudentName { get; set;}

        [Required]
        public string Email { get; set;}

        [Required]
        public string MobileNoStudent { get; set;}

        [Required]
        public string MobileNoFather { get; set;}

        [Required]
        public string Address { get; set;}
    }
}
