namespace RefrigeratorApp.Products
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

}
