using Desert.Orca.Domain.Catalog;
using Desert.Orca.Domain.Catalog.Rat;

namespace Desert.Orca.Domain.Orders.Item
{
    public class OrderItem
    {
        public int Id { get; set; }
        public OrderItem Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}