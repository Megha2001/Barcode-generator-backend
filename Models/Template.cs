using System.ComponentModel.DataAnnotations;

namespace BarcodeFinal.Models
{
    public class Template
    {
        [Key]
        public Guid TemplateReferenceId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string TemplateJson { get; set; }
    }
}
