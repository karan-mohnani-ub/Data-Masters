using DataMastersAPI.Model;

namespace DataMastersAPI.Service.Interface
{
	public interface IEventService
	{
		Task<List<Event>> GetAll();
		Task<Event> Create(Event e);
	}
}
