﻿using System.ComponentModel.DataAnnotations;

namespace Form.Areas.LOC_City.Models
{
    public class LOC_CityModel
    {
        public int? CityID { get; set; }

        [Required]
        public string CityName { get; set; }

        [Required]
        public string CityCode { get; set; }

        [Required]
        public int StateID { get; set; }

        [Required]
        public int CountryID { get; set; }
    }
}
