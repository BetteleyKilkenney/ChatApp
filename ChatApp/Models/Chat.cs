using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class Chat
    {
        public int ChatID { get; set; }
        public string ChatText { get; set; }
        public DateTime ChatTimeStamp { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}