namespace CAproject.Models.Entities.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal fiyat { get; set; }
        public int Stok { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }   
        public string ModelAd { get; set; }   
    }
}
