using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {

            _products = new List<Product>  {

                new Product { ProductId = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 2, CategoryID = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
                new Product { ProductId = 3, CategoryID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
                new Product { ProductId = 4, CategoryID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
                new Product { ProductId = 5, CategoryID = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 }
            };
        }

        public void Add(Product product)
        {

            _products.Add(product);

        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {

            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {

            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {

            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {

            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            productToDelete.ProductName = product.ProductName;
            productToDelete.CategoryId = product.CategoryId;
            productToDelete.UnitPrice = product.UnitPrice;
            productToDelete.UnitsInStock = product.UnitsInStock;
        }

    }
}

