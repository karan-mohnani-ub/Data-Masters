using DataMastersAPI.Model;

namespace DataMastersAPI.Service.Interface
{
  public interface ICatalogueItemService
  {
    Task<List<CatalogueItem>> GetAll();
  }
}
