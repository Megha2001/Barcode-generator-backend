using System.Text.Json;

namespace BarcodeFinal.Models
{
    public class TemplateRequest
    {
        public string Name { get; set; }
        public JsonElement TemplateJson { get; set; }
    }
}
