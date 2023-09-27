namespace MyShopServices.DTOS
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Descriptions { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public ProductDto(string productName, int price, string Descriptions, string CategoryName, string ImageUrl)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Descriptions = Descriptions;
            this.CategoryName = CategoryName;
            this.ImageUrl = ImageUrl;
        }
    }
}
