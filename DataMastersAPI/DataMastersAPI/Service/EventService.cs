using DataMastersAPI.Model;
using DataMastersAPI.Repository.Interface;
using DataMastersAPI.Service.Interface;

namespace DataMastersAPI.Service
{
	public class EventService: IEventService
	{
        public readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

		public async Task<List<Event>> GetAll()
		{
			return await _eventRepository.GetAll();
		}

		public async Task<Event> Create(Event e)
		{
			return await _eventRepository.Create(e);
		}
	}
}
