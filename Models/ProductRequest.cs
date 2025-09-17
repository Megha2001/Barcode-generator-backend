using System.Text.Json;

namespace BarcodeFinal.Models
{
    public class ProductRequest
    {
        public string ProductId { get; set; }
        public JsonElement ProductDetails { get; set; }
        public Guid TemplateReferenceId { get; set; }
    }
}