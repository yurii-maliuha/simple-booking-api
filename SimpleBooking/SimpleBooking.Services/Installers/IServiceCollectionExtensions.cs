using Microsoft.Extensions.DependencyInjection;

namespace SimpleBooking.Services.Installers
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection AddBookingServices(this IServiceCollection services)
		{
			services.AddTransient<IPropertyService, PropertyService>();
			services.AddTransient<IRoomService, RoomService>();
			services.AddTransient<IFeedbackService, FeedbackService>();
			services.AddTransient<IBookingService, BookingService>();

			return services;
		}
	}
}
