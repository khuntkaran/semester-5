using System.ComponentModel.DataAnnotations;

namespace Form.Areas.LOC_State.Models
{
    public class LOC_StateModel
    {
        public int? StateID { get; set; }

        [Required]
        public String StateName { get; set; }

        [Required]
        public String StateCode { get; set; }

        [Required]
        public int CountryID { get; set; }

        public List<Dictionary<String,dynamic>>    Countrys { get; set;}
    }
}
