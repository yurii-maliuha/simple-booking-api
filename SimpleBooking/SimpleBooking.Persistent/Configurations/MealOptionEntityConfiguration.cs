using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleBooking.Domain.Models;

namespace SimpleBooking.Persistent.Configurations
{
	public class MealOptionEntityConfiguration : IEntityTypeConfiguration<MealOption>
	{
		public void Configure(EntityTypeBuilder<MealOption> builder)
		{
			builder.Property(x => x.Description)
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.HasData(
				new MealOption()
				{
					Id = 1,
					Description = "Breakfast included"
				},
				new MealOption()
				{
					Id = 2,
					Description = "Breakfast & Lunch"
				},
				new MealOption()
				{
					Id = 3,
					Description = "All included"
				}
			);
		}
	}
}
