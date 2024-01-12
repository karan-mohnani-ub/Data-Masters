using DataMastersAPI.Data;
using DataMastersAPI.Model;
using DataMastersAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataMastersAPI.Repository
{
	public class EventRepository: IEventRepository
	{
		private readonly DataMastersDbContext _context;

        public EventRepository(DataMastersDbContext context)
        {
            _context = context;
        }

		public async Task<List<Event>> GetAll()
		{
			return await _context.Event.ToListAsync();
		}

		public async Task<Event> Create(Event e)
		{

			_context.Event.Add(e);
			await _context.SaveChangesAsync();
			return await _context.Event.FindAsync(e.Id);
		}
	}
}
