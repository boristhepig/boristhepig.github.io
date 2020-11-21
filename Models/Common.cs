using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGRescue_System.Models
{
    public class Common
    {
        public static List<MessageType> GetMessageType()
        {
            List<MessageType> list = new List<MessageType>();
            list.Add(new MessageType() { Type = "Urgent", Name = "Urgent", Css = "check w3" });
            list.Add(new MessageType() { Type = "Contact", Name = "Contact", Css = "check w3" });
            list.Add(new MessageType() { Type = "Important", Name = "Important", Css = "check w3" });
            list.Add(new MessageType() { Type = "Action", Name = "Action", Css = "check w3" });
            list.Add(new MessageType() { Type = "Phone", Name = "Phone", Css = "check w3" });
            return list;

        }
    }
}