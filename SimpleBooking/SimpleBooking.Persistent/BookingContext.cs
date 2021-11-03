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

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Feedback>()
				.Property(x => x.Description)
				.HasMaxLength(500);

			builder.Entity<Property>()
				.Property(x => x.Description)
				.HasMaxLength(500);

			builder.Entity<Location>()
				.Property(x => x.Name)
				.HasMaxLength(250);

			builder.Entity<MealOption>()
				.Property(x => x.Description)
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.Entity<OrderState>()
				.Property(x => x.Status)
				.HasMaxLength(50)
				.IsUnicode(false);

			builder.Entity<OrderItem>();

			base.OnModelCreating(builder);
		}
	}
}
