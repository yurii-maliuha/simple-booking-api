using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleBooking.Persistent.Installers
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection AddBookingPersistent(this IServiceCollection services, string connectionStr)
		{
			//services.AddTransient((c) => new BookingContext(connectionStr));
			//services.AddScoped((c) => new BookingContext(connectionStr));
			//services.AddSingleton((c) => new BookingContext(connectionStr));

			services.AddDbContext<BookingContext>(c =>
			{
				c.UseSqlServer(connectionStr);

			}, ServiceLifetime.Singleton);

			return services;
		}
	}
}
