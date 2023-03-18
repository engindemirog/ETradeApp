using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes {
    public class ProductDal {
        public List<Product> GetAll() {
            //call data from database
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "IPhone 14 Plus", Description = "256 GB", UnitPrice = 40000 });
            products.Add(new Product { Id = 2, Name = "IPhone 13 Plus", Description = "256 GB", UnitPrice = 30000 });
            products.Add(new Product { Id = 3, Name = "IPhone 12 Plus", Description = "256 GB", UnitPrice = 20000 });
            products.Add(new Product { Id = 4, Name = "IPhone 11 Plus", Description = "256 GB", UnitPrice = 10000 });
            products.Add(new Product { Id = 5, Name = "IPhone 10 Plus", Description = "256 GB", UnitPrice = 5000 });

            return products;
        }
    }
}
