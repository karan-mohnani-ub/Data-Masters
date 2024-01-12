using DataMastersAPI.Model;
using DataMastersAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DataMastersAPI.Controller
{
	[Route("api/[controller]")]
	[Produces("application/json")]
	[ApiController]
	public class EventController : ControllerBase
	{
		private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

		[HttpGet]
		public async Task<ActionResult<List<Event>>> GetAll()
		{
			List<Event> eventList = await _eventService.GetAll();
			return Ok(eventList);
		}

		[HttpPost]
		public async Task<ActionResult<Event>> Create([FromBody] Event e)
		{
			Event eve = await _eventService.Create(e);
			return Ok(eve);
		}
	}
}
