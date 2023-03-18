using Business.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase {
        [HttpGet]
        public IActionResult Get() {
            ProductManager productManager = new ProductManager();
            return Ok(productManager.GetAll());
        }
    }
}
