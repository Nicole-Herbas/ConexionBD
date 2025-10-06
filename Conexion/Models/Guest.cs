using System.ComponentModel.DataAnnotations;

namespace Conexion.Models
{
    public sealed class Guest
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = default!;

        [Required]
        public bool Confirmed { get; set; }
    }
}
