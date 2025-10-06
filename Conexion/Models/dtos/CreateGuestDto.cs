using System.ComponentModel.DataAnnotations;

namespace Conexion.DTOs.Guests
{
    public sealed class CreateGuestDto
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = default!;

        public bool Confirmed { get; set; } = false;
    }
}
