using BarcodeFinal.Models;

namespace BarcodeFinal.Services
{
    public interface IProductService
    {
        public Product CreateProduct(ProductRequest productRequest);
    }
}