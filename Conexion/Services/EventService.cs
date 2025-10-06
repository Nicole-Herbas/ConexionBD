using Conexion.Models;
using Conexion.Models.dtos;
using Conexion.Repositories;

namespace Conexion.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _repo;
        public EventService(IEventRepository repo) => _repo = repo;

        public async Task<Event> Create(CreateEventDto dto)
        {
            if (dto.Capacity < 1) throw new InvalidOperationException("Capacity must be above 1.");
            var eve = new Event { Id = Guid.NewGuid(), Title = dto.Title.Trim(), Capacity = dto.Capacity, Date = dto.Date };
            await _repo.Add(eve);
            return eve;
        }

        public async Task<bool> Delete(Guid id)
        {
            var existing = await _repo.GetById(id);
            if (existing is null) return false;
            await _repo.Delete(id);
            return true;
        }

        public Task<IEnumerable<Event>> GetAll() => _repo.GetAll();
        public Task<Event?> GetById(Guid id) => _repo.GetById(id);
    }
}