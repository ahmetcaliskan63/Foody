using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class ProductManager : IProductSrevice
    {
        private readonly IProductSrevice _productSrevice;
        public ProductManager(IProductSrevice productSrevice)
        {
            _productSrevice = productSrevice;
        }
        public void TDelete(int id)
        {
            _productSrevice.TDelete(id);
        }

        public List<Product> TGetAll()
        {
            return _productSrevice.TGetAll();
        }

        public Product TGetById(int id)
        {
            return _productSrevice.TGetById(id);
        }

        public void TInsert(Product entity)
        {
            _productSrevice.TInsert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productSrevice.TUpdate(entity);
        }
    }
}
