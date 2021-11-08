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
			var property1 = _context.Properties.Find(id);
			var property2 = _context.Properties.Find(id);

			return Task.FromResult(new PropertyDto());
		}
	}
}
