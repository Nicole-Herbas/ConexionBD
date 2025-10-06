using Conexion.Models;

namespace Conexion.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAll();
        Task<Event?> GetById(Guid id);
        Task Add(Event eve);
        Task Delete(Guid id);
    }
}