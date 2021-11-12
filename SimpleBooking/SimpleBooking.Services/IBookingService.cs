using SimpleBooking.Domain.Models;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public interface IBookingService
	{
		Task<Order> FindBestOrder();
	}
}
