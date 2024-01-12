using System.ComponentModel.DataAnnotations.Schema;

namespace DataMastersAPI.Model
{
	[Serializable]
	[Table("CatalogueItem")]
	public class CatalogueItem
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public decimal UnitCost { get; set; }

		public decimal UnitPrice { get; set; }

		public DateTime Created { get; }
	}
}
