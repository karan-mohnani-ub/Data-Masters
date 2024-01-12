using DataMastersAPI.Model;

namespace DataMastersAPI.Repository.Interface
{
	public interface IEventRepository
	{
		Task<List<Event>> GetAll();
		Task<Event> Create(Event e);
	}
}
