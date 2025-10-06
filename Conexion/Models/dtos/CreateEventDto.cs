using System.ComponentModel.DataAnnotations;

namespace Conexion.Models.dtos
{
    public class CreateEventDto
    {
        [Required, StringLength(200)]
        public string Title { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }

        [Range(1, 2100)]
        public int Capacity { get; set; }
    }
}