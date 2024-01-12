using DataMastersAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DataMastersAPI.Data
{
	public class DataMastersDbContext: DbContext
	{
    public DataMastersDbContext(DbContextOptions<DataMastersDbContext> options) : base(options)	{ }

		public DbSet<Event> Event { get; set; }

		public DbSet<Contact> Contact { get; set; }

		public DbSet<CatalogueItem> CatalogueItem { get; set; }

		public DbSet<EventCatalogueItem> EventCatalogueItem { get; set; }

		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await base.SaveChangesAsync(cancellationToken);
		}
	}
}
