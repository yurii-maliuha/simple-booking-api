using System;

namespace SimpleBooking.PersistentLogs
{
	public class Log
	{
		public Guid Id { get; set; }
		public string Description { get; set; }
		public DateTime Created { get; set; }
	}
}
