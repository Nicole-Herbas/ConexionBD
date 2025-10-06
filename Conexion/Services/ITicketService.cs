using Conexion.Models;
using Conexion.Models.dtos;
using conexion_bd_tecweb.Models;

namespace Conexion.Services
{
    public interface IEventService
    {
        Task<Event> Create(CreateTicketDto dto);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<Event>> GetAll();
        Task<Event?> GetById(Guid id);
    }
}