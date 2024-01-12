using System.ComponentModel.DataAnnotations.Schema;

namespace DataMastersAPI.Model
{
	[Serializable]
	[Table("Contact")]
	public class Contact
	{
		public long Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime Created { get; }
	}
}
