using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add (Product product);
        void up(Product product);
        void Delete(Product product);
        List<Product> GetByCategory(int categoryId);  //ürünleri katogoriye göre filtrele.

    }
}
