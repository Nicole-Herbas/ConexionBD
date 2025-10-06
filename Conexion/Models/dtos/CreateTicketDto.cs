using System.ComponentModel.DataAnnotations;

namespace Conexion.DTOs.Guests
{
    public sealed class CreateGuestDto
    {
        [Required]
        [MaxLength(200)]
        public string Notes { get; set; } = default!;

    }
}
