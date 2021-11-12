using SimpleBooking.Domain.Models;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public interface IRoomService
	{
		Task<Room> GetRoom(int id);
	}
}
