using SYSProject.Core.Utilities.Results;
using SYSProject.Entities.Concrete;
using SYSProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(long id);
        bool Add(ProductDto product, long userId);
        bool Update(long id, ProductDto product, long userId);
        bool Delete(long id, long userId);
    }
}
