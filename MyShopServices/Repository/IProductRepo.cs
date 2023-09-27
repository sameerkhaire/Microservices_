using MyShopServices.DTOS;
namespace MyShopServices.Repository
{
    public interface IProductRepo
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductId(int productId);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
