using SYSProject.Business.Abstract;
using SYSProject.Business.Constants;
using SYSProject.Core.DataAccess;
using SYSProject.Core.Utilities.Results;
using SYSProject.Entities.Concrete;
using SYSProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IGenericRepository<Product> _productDal;

        public ProductManager(IGenericRepository<Product> productDal)
        {
            _productDal = productDal;
        }

        public bool Add(ProductDto newProduct, long userId)
        {
            return _productDal.Add(new Product() {
                Name=newProduct.Name,
                BuyUnitPrice=newProduct.BuyUnitPrice,
                SaleUnitPrice=newProduct.SaleUnitPrice 
            }, userId);
        }

        public Product Get(long id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(p => p.IsDeleted != true);
        }

        public bool Update(long id, ProductDto model, long userId)
        {
            var product = _productDal.Get(p => p.Id == id);
            if (product == null)
                return false;
            product.Name = model.Name;
            product.SaleUnitPrice = model.SaleUnitPrice;
            product.BuyUnitPrice = model.BuyUnitPrice;
          return  _productDal.Update(product, userId); 
        }
        public bool Delete(long id, long userId)
        {
            var productToDelete = _productDal.Get(p => p.Id == id);
            if (productToDelete == null)
                return false;
            return _productDal.Delete(productToDelete, userId);
        }
    }
}
