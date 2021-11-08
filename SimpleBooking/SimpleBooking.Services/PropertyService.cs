using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Dtos;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace SimpleBooking.Services
{
	public class PropertyService : IPropertyService
	{
		private BookingContext _context;
		public PropertyService(BookingContext context)
		{
			_context = context;
		}

		public Task<PropertyDto> CreateTestProperty()
		{
			var location = new Location()
			{
				Name = "Test Location"
			};

			var property = new Property()
			{
				Description = "Test desc",
				Name = "Test name",
				FeedbackId = null
			};

			//using var transaction = _context.Database.BeginTransaction(IsolationLevel.Serializable);
			return Task.FromResult(new PropertyDto());
		}

		public Task<PropertyDto> GetProperty(int id)
		{
			var property1 = _context.Properties.Find(id);
			var property2 = _context.Properties.Find(id);

			return Task.FromResult(new PropertyDto());
		}
	}
}
