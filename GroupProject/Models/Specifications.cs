namespace GroupProject.Models
{
    public class Specifications
    {
        private readonly Guid _id;
        private string _specification=string.Empty;
        private Guid _productID;
        private Products _product;


        public Guid Id
        {
            get => _id;
        }

        public string Specification
        {
            get => _specification;
            set => _specification = value;
        }

        public Guid ProductID
        {
            get => _productID;
            set => _productID = value;
        }
        public Products Product
        {
            get => _product;
            set => _product = value;
        }

        public Specifications()
        {
            _id = Guid.NewGuid();
        }
    }
}
