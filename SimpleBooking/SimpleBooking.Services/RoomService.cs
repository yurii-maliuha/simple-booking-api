using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public class RoomService : IRoomService
	{
		private readonly BookingContext _context;
		public RoomService(BookingContext context)
		{
			_context = context;
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
