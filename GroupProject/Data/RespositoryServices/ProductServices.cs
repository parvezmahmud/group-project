using GroupProject.Models;

namespace GroupProject.Data.RespositoryServices
{
    public class ProductServices: IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public Products GetSingle(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
