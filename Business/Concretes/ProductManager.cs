using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes {
    public class ProductManager {
        public List<Product> GetAll() {

            //business rules

            ProductDal productDal = new ProductDal();
            return productDal.GetAll();
        }
    }
}
