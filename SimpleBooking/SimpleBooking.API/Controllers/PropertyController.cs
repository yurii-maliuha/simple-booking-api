using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBooking.Services;

namespace SimpleBooking.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertyController : ControllerBase
	{
		private readonly IPropertyService _propertyService;
		public PropertyController(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<IActionResult> GetProperty(int id)
		{
			var result = await _propertyService.GetProperty(id);
			return Ok(result);
		}

		[HttpGet]
		[Route("room/{id:int}")]
		public async Task<IActionResult> GetRoom(int id)
		{
			var result = await _propertyService.GetRoom(id);
			return Ok(result);
		}

		[HttpGet]
		[Route("feedback/{id:int}")]
		public async Task<IActionResult> GetFeedback(int id)
		{
			var result = await _propertyService.GetFeedbacks(id);
			return Ok(result);
		}
	}
}
