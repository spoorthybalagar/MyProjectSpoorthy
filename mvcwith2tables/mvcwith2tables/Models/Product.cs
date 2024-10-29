namespace mvcwith2tables.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
        //public List<Category> Categories { get; set; }
    }
}
