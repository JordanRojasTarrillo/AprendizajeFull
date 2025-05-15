namespace MiniMarketCarrito.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Emoji { get; set; } = string.Empty;
    }
}