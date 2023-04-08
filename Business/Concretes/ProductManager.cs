using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Rules;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes {
    public class ProductManager : IProductService {

        //dependency injection
        private IProductDal _productDal;
        ProductBusinessRules rules;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            rules = new ProductBusinessRules(_productDal);
        }

        public void Add(CreateProductRequest createProductRequest)
        {
            //business analyst
            //product names can not be duplicated

             
            rules.ProductNameCanNotBeDuplicated(createProductRequest.Name);

            //spaghetti
            //reusibility


            //mapping
            Product product = new Product
            {
                Name = createProductRequest.Name,
                Description = createProductRequest.Description,
                UnitPrice = createProductRequest.UnitPrice,
                CategoryId = createProductRequest.CategoryId
            };
            _productDal.Add(product);


            //try-catch
            //if
        }

        public List<Product> GetAll() {

            //business rules
            return _productDal.GetList().ToList();
        }

        public List<Product> GetAll(string productName)
        {
            return _productDal.GetList(p=>p.Name.Contains(productName)).ToList();
        }
    }
}