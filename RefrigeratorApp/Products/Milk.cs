namespace RefrigeratorApp.Products
{
    public class Milk : Product
    {
        public Milk(double quantity)
        {
            Id = 1;
            Name = "Milk";
            Quantity = quantity;
            ExpiryDate = DateTime.Now.AddDays(3);
        }
        public Milk(double quantity, DateTime expiryDate)
        {
            Id = 1;
            Name = "Milk";
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}

