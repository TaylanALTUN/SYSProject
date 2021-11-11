using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Entities.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal SaleUnitPrice { get; set; }
        public decimal BuyUnitPrice { get; set; }
    }
}
