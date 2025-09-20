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
                CreatedAt = DateTime.UtcNow
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> CreateProducts(List<ProductRequest> productRequests)
        {
            var products = productRequests.Select(productRequest => new Product
            {
                ProductReferenceId = Guid.NewGuid(),
                TemplateReferenceId = productRequest.TemplateReferenceId,
                ProductId = productRequest.ProductId,
                ProductDetails = productRequest.ProductDetails.GetRawText(),
                CreatedAt = DateTime.UtcNow
            }).ToList();

            _context.Products.AddRange(products);
            _context.SaveChanges();
            return products;
        }
    }
}
