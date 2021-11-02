namespace SimpleBooking.Domain.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int OrderStateId { get; set; }
		public double Total { get; set; }
	}
}
