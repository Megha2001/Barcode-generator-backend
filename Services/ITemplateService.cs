using BarcodeFinal.Models;

namespace BarcodeFinal.Services
{
    public interface ITemplateService
    {
        public Template CreateTemplate(TemplateRequest templateRequest);
        public List<Template> GetAllTemplates();
        public Template GetTemplateById(string referenceId);
        public void DeleteTemplate(string referenceId);
    }
}
