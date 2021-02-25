﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {    //Oracle,sql server,postgres,mongoDb
            _products = new List<Product> {
                new Product{ProductId=1, CategorId=1, ProductName="Bardak",UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategorId=1, ProductName="Kamera",UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategorId=2, ProductName="Telefon",UnitPrice=15, UnitsInStock=2},
                new Product{ProductId=4, CategorId=2, ProductName="Klavye",UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategorId=2, ProductName="Fare",UnitPrice=85, UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {   //LINQ - Language Integrated Query


            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);



        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void up(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {   //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategorId = product.CategorId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;



        }

        

        List<Product> IProductDal.GetByCategory(int categoryId)
        {
           return _products.Where(p => p.CategorId == categoryId).ToList();
        }
    }
}
