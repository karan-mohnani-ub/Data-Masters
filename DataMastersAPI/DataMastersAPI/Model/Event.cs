using System.ComponentModel.DataAnnotations.Schema;

namespace DataMastersAPI.Model
{
	[Serializable]
	[Table("Event")]
	public class Event
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string Category { get; set; }

		public long ContactId { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public DateTime Created { get; }
	}
}
