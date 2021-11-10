using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Dtos;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public class PropertyService : IPropertyService
	{
		private BookingContext _context;
		public PropertyService(BookingContext context)
		{
			_context = context;
		}

		public Task<Property> GetProperty(int id)
		{
			var property1 = _context.Properties
				.Where(x => x.Id > id)
				.ToList();

			return Task.FromResult(property1.First());
		}

		public Task<Feedback> GetFeedbacks(int id)
		{
			var property1 = _context.Feedbacks
				.Where(x => x.Id > id)
				.ToList();


			return Task.FromResult(property1.First());
		}

		public Task<Room> GetRoom(int id)
		{
			var property1 = _context.Rooms
				.Where(x => x.Id > id)
				.ToList();


			return Task.FromResult(property1.First());
		}
	}
}
