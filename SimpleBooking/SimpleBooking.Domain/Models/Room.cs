using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBooking.Domain.Models
{
	public class Room
	{
		public int Id { get; set; }
		public int PropertyId { get; set; }
		public int RoomTypeId { get; set; }
		public int Price { get; set; }
	}
}
