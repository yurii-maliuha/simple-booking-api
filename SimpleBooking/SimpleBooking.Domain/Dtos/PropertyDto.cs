namespace SimpleBooking.Domain.Dtos
{
	public class PropertyDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int LocationId { get; set; }
		public int? FeedbackId { get; set; }
	}
}
