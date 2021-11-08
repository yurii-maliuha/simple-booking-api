using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBooking.Services.Installers
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection AddBookingServices(this IServiceCollection services)
		{
			services.AddTransient<IPropertyService, PropertyService>();

			return services;
		}
	}
}
