using System.ComponentModel.DataAnnotations;

namespace Form.Areas.MST_Student.Models
{
    public class MST_StudentModel
    {
        public int? StudentID { get; set; }

        [Required] 
        public int BranchID { get; set; }

        [Required]
        public int CityID { get; set; }

        [Required]
        public string StudentName { get; set;}

        [Required]
        public string Email { get; set;}

        [Required]
        public string MobileNoStudent { get; set;}

        [Required]
        public string MobileNoFather { get; set;}

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime? BirthDate { get; set;}

        [Required]
        public int? Age { get; set; }

        [Required]
        public bool? IsActive { get; set;}

        [Required]
        public string Gender { get; set;}

        [Required]
        public string Password { get; set;}

        public List<Branch> Branches { get; set;}

        public List<City> cities { get; set;}
    }


    public class Branch
    {
        [Required]
        public int BranchID { get; set; }

        [Required]
        public String BranchName { get; set; }
    }

    public class City
    {
        [Required]
        public int CityID { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}


