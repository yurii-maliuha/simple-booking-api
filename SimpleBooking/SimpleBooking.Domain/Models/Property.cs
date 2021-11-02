using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBooking.Domain.Models
{
	public class Property
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int LocationId { get; set; }
		public int RatingId { get; set; }
		public int ReviewId { get; set; }
	}
}
