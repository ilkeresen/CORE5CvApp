using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutComponent
    {
        [Key]
        public int AboutComponentID { get; set; }
        public string AboutComponentIcon { get; set; }
        public string AboutComponentContent { get; set; }
        public string AboutComponentText { get; set; }
    }
}
