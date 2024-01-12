using System.ComponentModel.DataAnnotations.Schema;

namespace DataMastersAPI.Model
{
	[Serializable]
	[Table("EventCatalogueItem")]
	public class EventCatalogueItem
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public int Qty { get; set; }

		public decimal UnitCost { get; set; }

		public decimal UnitPrice { get; set; }

		public decimal Profit { get; set; }

		public long CatalogueItemId { get; set; }

		public long EventId { get; set; }

		public DateTime Created { get; }
	}
}
