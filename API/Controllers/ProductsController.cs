using Business.Abstracts;
using Business.Concretes;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]/")]
    [ApiController]
    public class ProductsController : ControllerBase {

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_productService.GetAll());
        }

        [HttpGet("{productName}")]
        public IActionResult Get([FromRoute] string productName)
        {
            return Ok(_productService.GetAll(productName));
        }

        [HttpPost]
        public IActionResult Add(CreateProductRequest product)
        {
            _productService.Add(product);
            return Ok(product);
        }
    }
}