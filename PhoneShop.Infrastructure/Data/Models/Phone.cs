namespace PhoneShop.Infrastructure.Data.Models
{
    internal class Phone : BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string DisplayInches { get; set; } = string.Empty;
        public string Capacity  { get; set; } = string.Empty;
        public string Battery { get; set; } = string.Empty;
        public string MainCameraMegaPixels { get; set; } = string.Empty;
        public string AndroidVersion { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
