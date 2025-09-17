using BarcodeFinal.Database;
using BarcodeFinal.Models;

namespace BarcodeFinal.Services
{
    public class TemplateService: ITemplateService
    {
        private readonly AppDbContext _context;
        public TemplateService(AppDbContext context)
        {
            _context = context;
        }

        public Template CreateTemplate(TemplateRequest templateRequest)
        {
            var template = new Template
            {
                TemplateReferenceId = Guid.NewGuid(),
                Name = templateRequest.Name,
                TemplateJson = templateRequest.TemplateJson.GetRawText(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Templates.Add(template);
            _context.SaveChanges();
            return template;
        }

        public List<Template> GetAllTemplates()
        {
            return _context.Templates.ToList();
        }

        public Template GetTemplateById(string referenceId)
        {
            return _context.Templates.FirstOrDefault(x => x.TemplateReferenceId.ToString().Equals(referenceId));
        }
    }
}
