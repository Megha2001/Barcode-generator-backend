using BarcodeFinal.Database;
using BarcodeFinal.Models;

namespace BarcodeFinal.Services
{
    public class ProductService: IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct(ProductRequest productRequest)
        {
            var product = new Product
            {
                ProductReferenceId = Guid.NewGuid(),
                TemplateReferenceId = productRequest.TemplateReferenceId,
                ProductId = productRequest.ProductId,
                ProductDetails = productRequest.ProductDetails.GetRawText(),
                CreatedAt = DateTime.UtcNow,
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
    }
}
