using DataMastersAPI.Data;
using DataMastersAPI.Model;
using DataMastersAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataMastersAPI.Repository
{
  public class CatalogueItemRepository: ICatalogueItemRepository
  {
    private readonly DataMastersDbContext _context;

    public CatalogueItemRepository(DataMastersDbContext context)
    {
      _context = context;
    }

    public async Task<List<CatalogueItem>> GetAll()
    {
      return await _context.CatalogueItem.ToListAsync();
    }
  }
}
