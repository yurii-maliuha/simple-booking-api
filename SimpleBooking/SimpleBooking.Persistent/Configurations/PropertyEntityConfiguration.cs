using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent.Constants;
using System;
using System.Linq;

namespace SimpleBooking.Persistent.Configurations
{
	public class PropertyEntityConfiguration : IEntityTypeConfiguration<Property>
	{
		public void Configure(EntityTypeBuilder<Property> builder)
		{
			builder
				.Property(x => x.Description)
				.HasMaxLength(500);

			var initialId = 1;
			Randomizer.Seed = SeedDataConstants.SeedRandom;
			var feedbackIds = Enumerable.Range(1, SeedDataConstants.FeedbacksCount)
				.Select(x => new int?(x))
				.Append(null);
			var locationIds = Enumerable.Range(1, SeedDataConstants.LocationsCount);

			var propertyFaker = new Faker<Property>()
				.RuleFor(x => x.Id, f => initialId++)
				.RuleFor(x => x.Name, f => f.Company.CompanyName())
				.RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
				.RuleFor(x => x.FeedbackId, f => f.PickRandom(feedbackIds))
				.RuleFor(x => x.LocationId, f => f.PickRandom(locationIds));

			builder.HasData(propertyFaker.Generate(SeedDataConstants.PropertiesCount));
		}

	}
}
