using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBooking.Domain.Models
{
	public class RoomType
	{
		public int Id { get; set; }
		public bool WithDoubleBed { get; set; }
		public int Capacity { get; set; }
	}
}
