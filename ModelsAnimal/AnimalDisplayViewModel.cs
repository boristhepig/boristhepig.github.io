using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Web;

namespace MGRescue_System.ModelsAnimal
{
    public class AnimalDisplayViewModel
    {
        //PART ONE OF THE PROFILE ---------------BASICS------------------------
        [Display(Name ="Animal ID")]
        public Guid AnimalID { get; set; }

        [Display(Name = "Animal Name")]
        public string AnimalName { get; set; }

        [Display(Name = "Species")]
        public string SpeciesName { get; set; }

        [Display(Name = "Breed")]
        public string BreedName { get; set; }

        [Display(Name = "Age in Years")]
        public Nullable <int> Years { get; set; }

        [Display(Name = "Months")]
        public Nullable <int> Months { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Primary Colour")]
        public string Primary_Colour { get; set; }

        [Display(Name = "Seconday Colour")]
        public string Secondary_Colour { get; set; }

        [Display(Name = "Third Colour")]
        public string Tertiary_Colour { get; set; }

        [Display(Name ="Coat Type")]
        public string Coat_Type { get; set; }

        [Display(Name = "Distinquishing marks")]
        public string Particular_Markings { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image File")]
        public string ImagePath { get; set; }

        [Display(Name = "Image")]
        private string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        //PART TWO OF THE PROFILE ----------------MEDICAL--------------------------

        public string Operations { get; set; }

        [Display(Name = "Health Problems")]
        public string Health_Problems { get; set; }
        public string Medications { get; set; }
        public string Bloodtested { get; set; }

        [Display(Name = "Date Blood Tested")]
        public System.DateTime Blood_test_Date { get; set; }

        [Display(Name = "Animal's Vet")]
        public string Animals_Vet { get; set; }

        [Display(Name = "Vet's Address")]
        public string Vet_Address { get; set; }

        [Display(Name = "Other Medical Comments")]
        public string Medical_Comments { get; set; }
    }
}