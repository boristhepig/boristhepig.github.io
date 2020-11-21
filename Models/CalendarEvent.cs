using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MGRescue_System.Models
{
    public class CalendarEvent
    {
        [DataMember]
        private string title;
        [DataMember]
        private string description;
        [DataMember]
        private string start;
        [DataMember]
        private string end;
        [DataMember]
        private string allday;
        [DataMember]
        private string url;
        [DataMember]
        private string color;
        [DataMember]
        private string borderColor;
        [DataMember]
        private string textColor;
    }
   
}