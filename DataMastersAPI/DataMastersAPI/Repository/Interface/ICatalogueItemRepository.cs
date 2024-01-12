using DataMastersAPI.Model;

namespace DataMastersAPI.Repository.Interface
{
  public interface ICatalogueItemRepository
  {
    Task<List<CatalogueItem>> GetAll();
  }
}
