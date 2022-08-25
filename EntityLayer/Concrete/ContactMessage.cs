using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactMessage
    {
        [Key]
        public int ContactMessageID { get; set; }
        public string ContactMessageName { get; set; }
        public string ContactMessageMail { get; set; }
        public string ContactMessageSubject { get; set; }
        public string ContactMessageContent { get; set; }
        public DateTime ContactMessageDate { get; set; }
        public bool ContactMessageApproval { get; set; }
        public bool ContactMessageStatus { get; set; }
    }
}
