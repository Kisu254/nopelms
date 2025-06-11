using Microsoft.AspNetCore.Mvc;
using Lms.Data;          
using Lms.Models;        
using System.Linq;

namespace Lms.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class TemplatesController : ControllerBase
	{

		private readonly LmsDbContext _context;

		public TemplatesController(LmsDbContext context)
		{
			_context = context;
		}

		// GET: api/templates
		[HttpGet]
		public IActionResult GetTemplates()
		{
			var templates = _context.NotificationTemplates.ToList();
			return Ok(templates);
		}
		// GET: api/templates/{id}
		[HttpGet("{id}")]
		public IActionResult GetTemplate(int id)
		{
			var template = _context.NotificationTemplates.Find(id);
			if (template == null)
			{
				return NotFound();
			}
			return Ok(template);
		}
	}
}