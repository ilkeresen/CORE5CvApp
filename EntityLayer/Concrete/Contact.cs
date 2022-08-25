using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactMainHeader { get; set; }
        public string ContactIcon { get; set; }
        public string ContactHeader { get; set; }
        public string ContactContent { get; set; }
    }
}
