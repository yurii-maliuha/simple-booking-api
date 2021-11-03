﻿namespace SimpleBooking.Domain.Models
{
	public class Property
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int LocationId { get; set; }
		public int FeedbackId { get; set; }

		public Location Location { get; set; }
		public Feedback Feedback { get; set; }
	}
}
