using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class Adoption
    {
        [Key]
        [Column(Order = 1)]
        public Guid AnimalID { get; set; }

        [Required]
        [MaxLength(128)]
        public string AnimalName { get; set; }

        //[Required]
        [MaxLength(3)]
        public string SpeciesIso3 { get; set; }

        //[Required]
        [MaxLength(3)]
        public string BreedCode { get; set; }

        public virtual Species Species { get; set; }

        public virtual Breed Breed { get; set; }

        public string ReferenceNumber { get; set; }
        public string Sex { get; set; }

        [Display(Name = "Primary Colour")]
        public string Primary_Colour { get; set; }

        [Display(Name = "Seconday Colour")]
        public string Secondary_Colour { get; set; }

        [Display(Name = "Third Colour")]
        public string Tertiary_Colour { get; set; }

        [Display(Name = "Coat type")]
        public string Coat_Type { get; set; }
        public Nullable<int> Years { get; set; }
        public Nullable<int> Months { get; set; }
        public string Description { get; set; }

        [Display(Name = "Distinquishing marks")]
        public string Particular_Markings { get; set; }

        [Display(Name = "Select Image")]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        private string Image { get; set; }

        [Display(Name = "Animal Comments")]
        public string Animal_Comments { get; set; }



        //Previous Medical details ------------------------------------------------------------------------
        public string Operations { get; set; }

        [Display(Name = "Health Problems")]
        public string Health_Problems { get; set; }
        public string Medications { get; set; }
        public string Bloodtested { get; set; }

        [Display(Name = "Date Blood Tested")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Blood_test_Date { get; set; }

        [Display(Name = "Animal's Vet")]
        public string Animals_Vet { get; set; }

        [Display(Name = "Vet's Address")]
        public string Vet_Address { get; set; }

        [Display(Name = "Other Medical Comments")]
        public string Medical_Comments { get; set; }

        //Basic Health care-------------------------------------------------------------------
        public string Microchipped { get; set; }

        [Display(Name = "Chip Number")]
        public string ChipNumber { get; set; }
        public string Vaccinated { get; set; }

        [Display(Name = "Date Vaccinated")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Vac_Date { get; set; }

        [Display(Name = "Vax Type")]
        public string Vac_Type { get; set; } //choice 1st 2nd Booster
        public string Neutered { get; set; }

        [Display(Name = "Date Neutered")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Neutered_Date { get; set; }

        [Display(Name = "Recently Flea Treated")]
        public string Flead { get; set; }//choice yes no unknown

        [Display(Name = "Date Last Flea Treated")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Flead_Date { get; set; }

        [Display(Name = "Recently Wormed")]
        public string Wormed { get; set; }//choice yes no unknown

        [Display(Name = "Date Last Wormed")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Wormed_Date { get; set; }




        [Display(Name = "Type of Special Diet")]
        public string Special_Diet_Type { get; set; }

        [Display(Name = "Product")]
        public string Diet_Product { get; set; }
        public string Amount { get; set; }

        [Display(Name = "Number of meals")]
        public string Diet_Frequency { get; set; }

        [Display(Name = "Day/Week/Month etc")]
        public string Diet_Frequency_Type { get; set; }

        [Display(Name = "Date to Start Diet")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Diet_Start { get; set; }

        [Display(Name = "Date to End Diet")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Diet_End { get; set; }

        [Display(Name = "Other Dietary Comments")]
        public string Diet_Comments { get; set; }

        //Present Treatments record---------------------------------------------------------------------
        [Display(Name = "Presently Vaccinated")]
        public string Vac_Treatment { get; set; }

        [Display(Name = "Date Vaccinated")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Treatment_Date { get; set; }

        [Display(Name = "Next Date Due")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Next_Due { get; set; }

        [Display(Name = "Other Treatment")]
        public string Other_Treatment { get; set; }

        [Display(Name = "Treatment Name")]
        public string Treatment_Name { get; set; }

        [Display(Name = "Start Treatment")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Start_Treatment { get; set; }

        [Display(Name = "End Treatment")]
        [Column(TypeName = "datetime2")]
        public System.DateTime End_Treatment { get; set; }
        public string Dosage { get; set; }

        [Display(Name = "Numer of Doses")]
        public string Dose_Frequency { get; set; }

        [Display(Name = "Day/Week/Month etc")]
        public string Dose_Frequecy_Type { get; set; }//Choice day week month year
        public string Specific_Info { get; set; }

        //Ownership Details---------------------------------------------------------------------
        [Display(Name = "Person Signing Over")]
        public string Person_Type { get; set; } //Choice friend etc

        [Display(Name = "First Name")]
        public string Persons_FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Persons_Surname { get; set; }

        [Display(Name = "Address")]
        public string Persons_Address { get; set; }

        [Display(Name = "Phone Number")]
        public string Persons_Phone_Number { get; set; }

        [Display(Name = "Reason for Entry")]
        public string Reason_for_entry { get; set; }

        [Display(Name = "Date of Entry")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Entry_Date { get; set; }

        [Display(Name = "Other Details")]
        public string Other_Details { get; set; }

        //Behavioural----------------------------------------------------------------------

        [Display(Name = "Good with Dogs")]
        public string Good_With_Dogs { get; set; }//choices yes no unknown

        [Display(Name = "Experience with Dogs")]
        public string Experience_with_Dogs { get; set; }

        [Display(Name = "Good with Cats")]
        public string Good_With_Cats { get; set; }//choices yes no unknown

        [Display(Name = "Experience with Cats")]
        public string Experience_with_Cats { get; set; }

        [Display(Name = "Good with Smallies")]
        public string Good_With_Smallies { get; set; }//choices yes no unknown

        [Display(Name = "Experience with Smallies")]
        public string Experience_with_Smallies { get; set; }

        [Display(Name = "Good with Kids")]
        public string Good_With_Kids { get; set; }//choices yes no unknown

        [Display(Name = "Experience with Kids")]
        public string Experience_with_Kids { get; set; }

        [Display(Name = "Childrens ages")]
        public string Child_ages { get; set; } //different type of dropdownlist added to view

        [Display(Name = "Good with Strangers")]
        public string Good_with_Strangers { get; set; }//choices yes no unknown

        [Display(Name = "Experience with Strangers")]
        public string Experience_with_Strangers { get; set; }

        [Display(Name = "Ever bitten")]
        public string Biting { get; set; }//choices yes no unknown

        [Display(Name = "Details of Bite")]
        public string Bite_Details { get; set; }

        public string Possessive { get; set; }//choices yes no unknown

        [Display(Name = "Details of Posessiveness")]
        public string Possessive_Details { get; set; }

        [Display(Name = "Fearful")]
        public string Fear { get; set; }//choices yes no unknown

        [Display(Name = "Details about being fearful")]
        public string FearDetails { get; set; }

        [Display(Name = "Well Behaved at Vets")]
        public string Behaviour_at_Vets { get; set; }//Text area

        [Display(Name = "Animal's Character")]
        public string Animal_Demeanor { get; set; }//TextArea

        [Display(Name = "Behaviour at Groomers")]
        public string Behaviour_at_Groomers { get; set; }//TextArea

        [Display(Name = "Being Left Alone")]
        public string Left_Alone { get; set; }//TextArea

        [Display(Name = "Good with Food")]
        public string Good_with_Food { get; set; }//choice

        [Display(Name = "Good Being Handled")]
        public string Good_being_Handled { get; set; }//choice

        [Display(Name = "Known Commands")]
        public string Commands { get; set; }

        [Display(Name = "Other Commands")]
        public string Commands_Comments { get; set; }

        [Display(Name = "Other Behaviour Comments")]
        public string Behavioural_Comments { get; set; }

        //Movements------------------------------------------------------
        [Display(Name = "Movement Type")]
        public string Movement_Type { get; set; }

        [Display(Name = "Date of Movement")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Movement_Date { get; set; }

        [Display(Name = "Date Reserved")]
        [Column(TypeName = "datetime2")]
        public System.DateTime Reserved_Date { get; set; }

        [Display(Name = "Length")]
        public string Reserve_Length { get; set; }

        [Display(Name = "Days/Weeks etc")]
        public string Reserve_Length_Type { get; set; }
    }
}