using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SimpleBooking.Persistent;
using SimpleBooking.Persistent.Installers;
using SimpleBooking.Services.Installers;
using SimpleBooking.PersistentLogs.Installers;

namespace SimpleBooking.API
{
	public class Startup
	{
		private readonly IConfiguration _configuration;
		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}


		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddBookingPersistent(_configuration.GetConnectionString("BookingDb"));
			services.AddPersistentLogs(_configuration.GetConnectionString("LogsDb"));
			services.AddBookingServices();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
