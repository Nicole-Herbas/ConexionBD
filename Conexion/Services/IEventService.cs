using Conexion.Models;
using Conexion.Models.dtos;

namespace Conexion.Services
{
    public interface IEventService
    {
        Task<Event> Create(CreateEventDto dto);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<Event>> GetAll();
        Task<Event?> GetById(Guid id);
    }
}
