using GroupProject.Data.RespositoryServices;
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private IProduct _service;
        public ProductController(IProduct service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
    }
}
