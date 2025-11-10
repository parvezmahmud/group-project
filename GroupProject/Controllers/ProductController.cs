using GroupProject.Data;
using GroupProject.Data.RespositoryServices;
using GroupProject.Models;
using GroupProject.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroupProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        //private IProduct _service;

        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.Include(a=>a.Specifications).ToList();
            if(products.Count > 0)
            {
                return Ok(products);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var data = _context.Products.Include(a=>a.Specifications).SingleOrDefault(z=>z.Id == id);
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(ProductDTO productdto)
        {
            var product = new Products
            {
                ProductName = productdto.ProductName,
                Price = productdto.Price,
                Availability = productdto.Availability,
                AvailableFrom = productdto.AvailableFrom
            };


            try
            {
                
                foreach (var specification in productdto.Specifications)
                {
                    var spec = new Specifications
                    {
                        Specification = specification.Specification,
                    };
                    product.Specifications.Add(spec);
                }
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok(product);
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put(Guid id, Products productDTO)
        {
            var product = _context.Products.Include(a=>a.Specifications).SingleOrDefault(i=>i.Id== id);
            var entry = _context.Entry(product);
            //_context.Entry(product).State = EntityState.Detached;
            product.ProductName= productDTO.ProductName;
            product.AvailableFrom= productDTO.AvailableFrom;
            product.Availability= productDTO.Availability;
            product.Price= productDTO.Price;

            entry.CurrentValues.SetValues(product);

            //product.Specifications = new List<Specifications>();

            try
            {
                var specs = _context.Specifications.Where(q => q.ProductID == id).ToList();
                //product.Specifications.Clear();
                foreach(var item in specs)
                {
                    var exist = specs.SingleOrDefault(a => a.Id == item.Id);
                    if (exist != null)
                    {
                        exist.Specification = item.Specification;
                    }
                    else
                    {
                        item.Product = product;
                        product.Specifications.Add(item);
                    }
                    //product.Specifications.Add(item);
                }
                _context.SaveChanges();
                //foreach(var specification in productDTO.Specifications)
                //{
                //    var spec = new Specifications
                //    {
                //        Specification = specification.Specification,
                //    };
                //    product.Specifications.Add(spec);
                //}
                return Ok("Updated Successfully");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
