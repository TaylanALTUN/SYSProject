using SYSProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Entities.Concrete
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal SaleUnitPrice { get; set; }
        public decimal BuyUnitPrice { get; set; }
    }
}
