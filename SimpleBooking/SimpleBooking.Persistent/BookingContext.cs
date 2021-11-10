using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Models;

namespace SimpleBooking.Persistent
{
	public class BookingContext : DbContext
	{
		private readonly string _connectionStr;
		public BookingContext(string connectStr)
		{
			_connectionStr = connectStr;
		}

		public BookingContext(DbContextOptions<BookingContext> options)
			: base(options)
		{

		}

		public DbSet<Order> Orders{ get; set; }
		public DbSet<Property> Properties { get; set; }

		public DbSet<Room> Rooms { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer(_connectionStr);
		//}

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
