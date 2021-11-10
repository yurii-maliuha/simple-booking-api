using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Models;

namespace SimpleBooking.Persistent
{
	public class BookingContext : DbContext
	{
		public BookingContext()
		{

		}

		public BookingContext(DbContextOptions<BookingContext> options)
			: base(options)
		{

		}

		public DbSet<Order> Orders{ get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<Log> Logs { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<OrderState>()
				.Property(x => x.Status)
				.HasMaxLength(50)
				.IsUnicode(false);

			builder.Entity<OrderItem>();

			builder.ApplyConfigurationsFromAssembly(typeof(BookingContext).Assembly);
			base.OnModelCreating(builder);
		}
	}
}
