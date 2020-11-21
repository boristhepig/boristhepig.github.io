using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class Feedback
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string MessageType { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        [StringLength(255)]
        public string To { get; set; }
        public string From { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}