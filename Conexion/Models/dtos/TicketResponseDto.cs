namespace Conexion.DTOs.Guests
{
    public sealed class GuestResponseDto
    {
        public Guid Id { get; set; }
        public string Notes { get; set; } = default!;
    }
}