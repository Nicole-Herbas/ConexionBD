using System.ComponentModel.DataAnnotations;

namespace conexion_bd_tecweb.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
