using BarcodeFinal.Database;
using BarcodeFinal.Models;
using Microsoft.EntityFrameworkCore;

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
            return _context.Templates.OrderBy(t => t.CreatedAt).ToList();
        }

        public Template GetTemplateById(string referenceId)
        {
            return _context.Templates.FirstOrDefault(x => x.TemplateReferenceId.ToString().Equals(referenceId));
        }

        public void DeleteTemplate(string referenceId)
        {
            var template = _context.Templates
                .FirstOrDefault(t => t.TemplateReferenceId.ToString() == referenceId);

            if (template == null)
            {
                return;
            }

            _context.Templates.Remove(template);
            _context.SaveChanges();
        }
    }
}
