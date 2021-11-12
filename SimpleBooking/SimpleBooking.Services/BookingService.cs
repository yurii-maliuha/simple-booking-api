using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using System;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public class BookingService : IBookingService
	{
		private readonly IPropertyService _propertyService;
		private readonly IRoomService _roomService;
		private readonly IFeedbackService _feedbackService;
		private readonly BookingContext _context;

		public BookingService(
			BookingContext context,
			IPropertyService propertyService,
			IRoomService roomService,
			IFeedbackService feedbackService)
		{
			_context = context;
			_propertyService = propertyService;
			_roomService = roomService;
			_feedbackService = feedbackService;
		}
		public Task<Order> FindBestOrder()
		{
			return Task.FromResult(new Order());
		}
	}
}
