using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Resume
    {
        [Key]
        public int ResumeID { get; set; }
        public string ResumeHeader { get; set; }
        public string ResumeDate { get; set; }
        public string ResumeAdress { get; set; }
        public string ResumeContent { get; set; }
    }
}
