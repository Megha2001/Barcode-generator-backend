using System.ComponentModel.DataAnnotations;

namespace BarcodeFinal.Models
{
    public class Product
    {
        [Key]
        public Guid ProductReferenceId { get; set; }

        public Guid TemplateReferenceId { get; set; }

        public string ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ProductDetails { get; set; }
    }

}
