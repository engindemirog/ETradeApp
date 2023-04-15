using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
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

        public List<GetProductResponse> GetAll() {

            //business rules
            List<Product> products = _productDal.GetAllWithCategory().ToList();

            List<GetProductResponse> getProductResponses = new List<GetProductResponse>();
            
            foreach (Product product in products)
            {
                GetProductResponse getProductResponse = new GetProductResponse();
                getProductResponse.Name = product.Name;
                getProductResponse.Description = product.Description;
                getProductResponse.UnitPrice = product.UnitPrice;
                getProductResponse.Id = product.Id;
                getProductResponse.CategoryId = product.CategoryId;
                getProductResponse.CategoryName=product.Category.Name;

                getProductResponses.Add(getProductResponse);
            }

            return getProductResponses;

        }

        public List<GetProductResponse> GetAll(string productName)
        {
            List<Product> products = 
                _productDal.GetAllWithCategory(productName).ToList();

            List<GetProductResponse> getProductResponses = new List<GetProductResponse>();

            foreach (Product product in products)
            {
                GetProductResponse getProductResponse = new GetProductResponse();
                getProductResponse.Name = product.Name;
                getProductResponse.Description = product.Description;
                getProductResponse.UnitPrice = product.UnitPrice;
                getProductResponse.Id = product.Id;
                getProductResponse.CategoryId = product.CategoryId;
                getProductResponse.CategoryName = product.Category.Name;

                getProductResponses.Add(getProductResponse);
            }

            return getProductResponses;
        }
    }
}