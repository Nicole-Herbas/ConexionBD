namespace Conexion.DTOs.Guests
{
    public sealed class GuestResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default!;
        public bool Confirmed { get; set; }
    }
}
