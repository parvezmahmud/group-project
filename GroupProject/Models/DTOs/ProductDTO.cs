namespace GroupProject.Models.DTOs
{
    public class ProductDTO
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Availability { get; set; }
        public DateOnly AvailableFrom { get; set; }
        public List<SpecificationDTO> Specifications { get; set; } = new();
    }
}
