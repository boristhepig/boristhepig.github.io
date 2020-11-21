using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class FeedbackViewModel
    {

        public string Message { get; set; }

        public string To { get; set; }

        public string From { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Select { get; set; }

        public List<MessageType> MessageTypes { get; set; }
    }
}