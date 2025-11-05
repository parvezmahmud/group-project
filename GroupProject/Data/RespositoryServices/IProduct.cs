using GroupProject.Models;

namespace GroupProject.Data.RespositoryServices
{
    public interface IProduct
    {
        IEnumerable<Products> GetAll();
    }
}
