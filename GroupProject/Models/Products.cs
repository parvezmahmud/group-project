namespace GroupProject.Models
{
    public class Products
    {
        private readonly Guid _id;
        private string _productName = string.Empty;
        private decimal _price;
        private bool _availability;
        private DateOnly _availableFrom;
        private readonly DateTime _created;
        private ICollection<Specifications> _specs;
        private ICollection<Category> _cats;

        public Guid Id
        {
            get => _id;
        }
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }
        public bool Availability
        {
            get => _availability;
            set => _availability= value;
        }
        public DateOnly AvailableFrom
        {
            get => _availableFrom;
            set => _availableFrom = value;
        }

        public DateTime Created
        {
            get => _created;
        }

        public ICollection<Specifications> Specifications
        {
            get => _specs;
            set => _specs = value;
        }

        public ICollection<Category> Category
        {
            get => _cats;
            set => _cats = value;
        }

        public Products()
        {
            _id = Guid.NewGuid();
            _created=DateTime.UtcNow;
            _specs = new List<Specifications>();
            _cats = new HashSet<Category>();
        }
    }
}
