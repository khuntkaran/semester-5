using System.ComponentModel.DataAnnotations;

namespace Form.Areas.LOC_Contry.Models
{
    public class LOC_CountryModel
    {
        public int? CountryID { get; set; }
        [Required]
        public string CountryName { get; set; }

        [Required]
        public string CountryCode { get; set; }
    }
}
