using DataAccess.Repository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //custom operations
        //method overloading
        List<Product> GetAllWithCategory();
        List<Product> GetAllWithCategory(string productName);
    }
}
