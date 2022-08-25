using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutImageUrl { get; set; }
        public string AboutMainHeader { get; set; }
        public string AboutHeader { get; set; }
        public string AboutFirstContent { get; set; }
        public string AboutDate { get; set; }
        public string AboutWebAdress { get; set; }
        public string AboutPhone { get; set; }
        public string AboutCity { get; set; }
        public string AboutAge { get; set; }
        public string AboutDegree { get; set; }
        public string AboutMail { get; set; }
        public string AboutFreelance { get; set; }
        public string AboutSecondContent { get; set; }
    }
}
