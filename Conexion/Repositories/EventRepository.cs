using Conexion.Models;
using Conexion.Data;
using Microsoft.EntityFrameworkCore;

namespace Conexion.Repositories
{
    public class EventRepository : IEventRepository
    {
        //private readonly List<Event> _events = new()
        //{
        //    new Book { Id = Guid.NewGuid(), Title = "Clean Code", Year = 2008 },
        //    new Book { Id = Guid.NewGuid(), Title = "Pragmatic Programmer", Year = 1999 },
        //    new Book { Id = Guid.NewGuid(), Title = "Refactoring", Year = 1999 }
        //};
        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(Event eve)
        {
            await _context.Events.AddAsync(eve);
        }

        public async Task Delete(Guid id)
        {
            var eve = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
            if (eve != null)
            {
                _context.Books.Remove(eve);
            }
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event?> GetById(Guid id)
        {
            return await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}