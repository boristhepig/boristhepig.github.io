using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class Breed
    {
        [Key]
        [MaxLength(3)]
        public string BreedCode { get; set; }
        [Required]
        [MaxLength(3)]
        public string Iso3 { get; set; }
        [Required]
        public string BreedNameEnglish { get; set; }
        //public virtual Specie Species { get; set; }
    }
}