using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
        //public string Content { get; set; }
        public string TodoContent { get; set; }
        public DateTime Date { get; set; }
        public bool status { get; set; }
    }
}
