using System.ComponentModel.DataAnnotations;

namespace Conexion.DTOs.Guests
{
    public sealed class UpdateGuestDto
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = default!;

        [Required]
        public bool Confirmed { get; set; }
    }
}
