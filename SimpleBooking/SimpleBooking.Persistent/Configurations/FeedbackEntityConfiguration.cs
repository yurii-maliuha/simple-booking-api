using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent.Constants;
using System;

namespace SimpleBooking.Persistent.Configurations
{
	public class FeedbackEntityConfiguration : IEntityTypeConfiguration<Feedback>
	{
		public void Configure(EntityTypeBuilder<Feedback> builder)
		{
			builder.Property(x => x.Description)
				.HasMaxLength(500);

			var initialId = 1;
			Randomizer.Seed = new Random(8675309);
			var feedbackFaker = new Faker<Feedback>()
				.RuleFor(x => x.Id, f => initialId++)
				.RuleFor(x => x.StarsCount, f => f.PickRandom<int>(1, 2, 3, 4, 5))
				.RuleFor(x => x.Description, f => f.Lorem.Sentences(3, "."));

			builder.HasData(feedbackFaker.Generate(SeedDataConstants.FeedbacksCount));
		}
	}
}
