using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ProductBusinessRules
    {
        IProductDal _productDal;

        public ProductBusinessRules(IProductDal productDal)
        {
            _productDal = productDal;
        }


        //product names can not be duplicated
        public void ProductNameCanNotBeDuplicated(string productName)
        {
            Product? product = _productDal.Get(p=>p.Name == productName);

            if (product != null)
            {
                throw new Exception("Product name already exists");
            }
        }
    }
}
