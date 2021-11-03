using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;

namespace SimpleBooking.Persistent.Configurations
{
	public class RoomTypeEntityConfiguration : IEntityTypeConfiguration<RoomType>
	{
		public void Configure(EntityTypeBuilder<RoomType> builder)
		{
			builder.HasData(
				new RoomType()
				{
					Id = 1,
					WithDoubleBed = true,
					Capacity = 2
				},
				new RoomType()
				{
					Id = 2,
					WithDoubleBed = true,
					Capacity = 3
				},
				new RoomType()
				{
					Id = 3,
					WithDoubleBed = false,
					Capacity = 2
				},
				new RoomType()
				{
					Id = 4,
					WithDoubleBed = false,
					Capacity = 3
				}
			);
		}
	}
}
