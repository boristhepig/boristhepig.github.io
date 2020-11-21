using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class Species
    {
        [Key]
        [MaxLength(3)]
        public string Iso3 { get; set; }
        public string SpeciesNameEnglish { get; set; }

        public virtual IEnumerable<Breed> Breeds { get; set; }
    }
}