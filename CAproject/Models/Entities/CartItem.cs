namespace CAproject.Models.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public decimal Fiyat { get; set; }
        public int Quantity { get; set; }
    }
}
