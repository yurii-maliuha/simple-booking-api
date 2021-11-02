namespace SimpleBooking.Domain.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int RoomId { get; set; }
		public int Amount { get; set; }
		public int OrderId { get; set; }
		public int MealOptionId { get; set; }
	}
}
