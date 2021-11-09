using Microsoft.EntityFrameworkCore;

namespace SimpleBooking.PersistentLogs
{
	public class LogsContext : DbContext
	{
		public LogsContext(DbContextOptions<LogsContext> options)
			: base(options)
		{

		}

		public DbSet<Log> Logs { get; set; }
	}
}
