using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent.Constants;
using System.Linq;

namespace SimpleBooking.Persistent.Configurations
{
	public class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
	{
		public void Configure(EntityTypeBuilder<Room> builder)
		{
			var initialId = 1;
			var roomFaker = new Faker<Room>()
				.RuleFor(x => x.Id, f => initialId++)
				.RuleFor(x => x.Price, f => f.PickRandom(Enumerable.Range(500, 1500)))
				.RuleFor(x => x.PropertyId, f => f.PickRandom(Enumerable.Range(1, SeedDataConstants.PropertiesCount)))
				.RuleFor(x => x.RoomTypeId, f => f.PickRandom(1, 2, 3, 4));

			builder.HasData(roomFaker.Generate(SeedDataConstants.RoomsCount));
		}
	}
}
