namespace RefrigeratorApp.RefrigeratorOperations
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
