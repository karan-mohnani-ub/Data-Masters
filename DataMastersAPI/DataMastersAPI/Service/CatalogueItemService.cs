using DataMastersAPI.Model;
using DataMastersAPI.Repository.Interface;
using DataMastersAPI.Service.Interface;

namespace DataMastersAPI.Service
{
  public class CatalogueItemService: ICatalogueItemService
  {
    public readonly ICatalogueItemRepository _catalogueItemRepository;

    public CatalogueItemService(ICatalogueItemRepository catalogueItemRepository)
    {
        _catalogueItemRepository = catalogueItemRepository;
    }

    public Task<List<CatalogueItem>> GetAll()
    {
      throw new NotImplementedException();
    }
  }
}
