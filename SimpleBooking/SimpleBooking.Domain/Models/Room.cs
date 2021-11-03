namespace SimpleBooking.Domain.Models
{
	public class Room
	{
		public int Id { get; set; }
		public int Price { get; set; }
		public int PropertyId { get; set; }
		public int RoomTypeId { get; set; }

		public Property Property { get; set; }
		public RoomType RoomType { get; set; }
	}
}
