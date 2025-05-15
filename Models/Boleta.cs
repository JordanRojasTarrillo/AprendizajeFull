using System.Collections.Generic;

namespace MiniMarketCarrito.Models
{
    public class Boleta
    {
        public List<ItemCarrito> Items { get; set; } = new List<ItemCarrito>();
        public decimal Subtotal { get; set; }
        public decimal IGV { get; set; }
        public decimal Total { get; set; }
    }
}