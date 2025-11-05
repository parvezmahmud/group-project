namespace GroupProject.Models
{
    public class Category
    {
        private readonly Guid _id;
        private string _catName = string.Empty;
        private ICollection<Products> _products;
        public Guid Id
        {
            get => _id;
        }

        public string CategoryName
        {
            get=> _catName;
            set => _catName = value;
        }

        public ICollection<Products> Products
        {
            get => _products;
            set => _products = value;
        }
        public Category()
        {
            _id = Guid.NewGuid();
            _products = new List<Products>();
        }
    }
}
