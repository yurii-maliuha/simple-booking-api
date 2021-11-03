namespace SimpleBooking.Domain.Models
{
	public class MealOption
	{
		public int Id { get; set; }

		// 'Breakfast included', 'Breakfast & Lunch', 'All included'
		public string Description { get; set; }
	}
}
