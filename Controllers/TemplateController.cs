using BarcodeFinal.Models;
using BarcodeFinal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeFinal.Controllers
{
    [Route("api/template")]
    [ApiController]
    public class TemplateController : Controller
    {
        private readonly ITemplateService templateService;
        public TemplateController(ITemplateService templateService)
        {
            this.templateService = templateService;
        }

        [HttpGet("all")]
        public IActionResult GetAllTemplates()
        {
            var data = templateService.GetAllTemplates();
            return Ok(data);
        }

        [HttpGet("{referenceId}")]
        public IActionResult GetTemplateById(string referenceId)
        {
            var data = templateService.GetTemplateById(referenceId);
            return Ok(data);
        }

        [HttpPost("")]
        public IActionResult CreateTemplate(TemplateRequest templateRequest)
        {
            var data = templateService.CreateTemplate(templateRequest);
            return Ok(data);
        }
    }
}
