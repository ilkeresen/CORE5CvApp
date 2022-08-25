using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Interest
    {
        [Key]
        public int InterestID { get; set; }
        public string InterestIcon { get; set; }
        public string InterestName { get; set; }
        public string InterestColor { get; set; }
    }
}
