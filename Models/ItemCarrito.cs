namespace MiniMarketCarrito.Models
{
    public class ItemCarrito
    {
        public Producto Producto { get; set; } = new Producto();
        public int Cantidad { get; set; }
    }
}