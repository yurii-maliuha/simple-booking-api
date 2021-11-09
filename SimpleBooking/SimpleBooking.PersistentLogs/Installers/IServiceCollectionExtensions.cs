using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleBooking.PersistentLogs.Installers
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection AddPersistentLogs(this IServiceCollection services, string connectionStr)
		{
			services.AddDbContext<LogsContext>(c =>
			{
				c.UseSqlServer(connectionStr);
			});

			return services;
		}
	}
}
