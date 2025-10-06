using Conexion.Models;
using Conexion.Models.dtos;
using Conexion.Repositories;
using conexion_bd_tecweb.Models;

namespace Conexion.Services
{
    public class EventService : ITicketService
    {
        private readonly ITicketRepository _repo;
        public EventService(ITicketRepository repo) => _repo = repo;
        Ti
        public async Task<Event> Create(CreateTicketDto dto)
        {
            if (dto.Capacity < 1) throw new InvalidOperationException("Capacity must be above 1.");
            var eve = new Event { Id = Guid.NewGuid(), Notes = dto.Notes.Trim()};
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