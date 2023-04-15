using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        //overloading
        List<GetProductResponse> GetAll();
        List<GetProductResponse> GetAll(string productName);

        void Add(CreateProductRequest createProductRequest);
    }
}
//add-migration init
//update-database