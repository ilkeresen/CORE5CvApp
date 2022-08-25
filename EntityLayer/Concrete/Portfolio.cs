using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string PortfolioFilter { get; set; }
        public string PortfolioHeader { get; set; }
        public string PortfolioContent { get; set; }
        public string PortfolioImageUrl { get; set; }
        public string PortfolioPrice { get; set; }
        public string PortfolioDate { get; set; }
        public int PortfolioValue { get; set; }
        public bool PortfolioStatus { get; set; }
    }
}
