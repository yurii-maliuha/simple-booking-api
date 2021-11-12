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
		private readonly IRoomService _roomService;
		private readonly IFeedbackService _feedbackService;
		private readonly IBookingService _bookingService;
		public PropertyController(
			IPropertyService propertyService,
			IRoomService roomService,
			IFeedbackService feedbackService,
			IBookingService bookingService)
		{
			_propertyService = propertyService;
			_roomService = roomService;
			_feedbackService = feedbackService;
			_bookingService = bookingService;
		}

		// Call three below for testing Singelton case
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
			var result = await _roomService.GetRoom(id);
			return Ok(result);
		}

		[HttpGet]
		[Route("feedback/{id:int}")]
		public async Task<IActionResult> GetFeedback(int id)
		{
			var result = await _feedbackService.GetFeedbacks(id);
			return Ok(result);
		}

		// Call it for testing Transient case
		[HttpGet]
		[Route("best-order")]
		public async Task<IActionResult> GetBestOrder()
		{
			var result = await _bookingService.FindBestOrder();
			return Ok(result);
		}
	}
}
