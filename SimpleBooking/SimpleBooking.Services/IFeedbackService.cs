using SimpleBooking.Domain.Models;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public interface IFeedbackService
	{
		Task<Feedback> GetFeedbacks(int id);
	}
}
