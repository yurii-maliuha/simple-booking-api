using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public class FeedbackService : IFeedbackService
	{
		private readonly BookingContext _context;

		public FeedbackService(BookingContext context)
		{
			_context = context;
		}

		public Task<Feedback> GetFeedbacks(int id)
		{
			var property1 = _context.Feedbacks
				.Where(x => x.Id > id)
				.ToList();


			return Task.FromResult(property1.First());
		}
	}
}
