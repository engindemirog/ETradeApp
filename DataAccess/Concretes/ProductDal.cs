using DataAccess.Abstracts;
using DataAccess.Contexts;
using DataAccess.Repository;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes {
    public class ProductDal : EfEntityRepositoryBase<Product, ETradeContext>, IProductDal
    {
        public List<Product> GetAllWithCategory()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Include(p => p.Category).ToList();
            }
        }

        public List<Product> GetAllWithCategory(string productName)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Include(p => p.Category)
                    .Where(p=>p.Name.ToLower().Contains(productName.ToLower())).ToList();
            }
        }
    }
}
