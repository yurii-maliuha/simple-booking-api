using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Dtos;
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

		public Task<PropertyDto> GetProperty(int id)
		{
			var property1 = _context.Rooms
				.Include(x => x.Property)
				.ThenInclude(x => x.Feedback)
				.Include(x => x.RoomType)
				.Where(x => x.PropertyId >= id)
				//.Take(100)
				.ToList();

			var feedback = _context.Feedbacks
				.ToList();
			



			return Task.FromResult(new PropertyDto());
		}
	}
}
