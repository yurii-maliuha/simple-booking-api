using Bogus;
using CountryData.Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent.Constants;
using System;

namespace SimpleBooking.Persistent.Configurations
{
	public class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
	{
		public void Configure(EntityTypeBuilder<Location> builder)
		{
			builder.Property(x => x.Name)
				.HasMaxLength(250);

			var initialId = 1;
			var locationFaker = new Faker<Location>()
				.RuleFor(x => x.Id, f => initialId++)
				.RuleFor(x => x.Name, f => f.Country().UnitedStates().State().Name);

			builder.HasData(locationFaker.Generate(SeedDataConstants.LocationsCount));
		}
	}
}
