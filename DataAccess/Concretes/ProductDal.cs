using DataAccess.Abstracts;
using DataAccess.Contexts;
using DataAccess.Repository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes {
    public class ProductDal : EfEntityRepositoryBase<Product,ETradeContext>, IProductDal {
        
    }
}
