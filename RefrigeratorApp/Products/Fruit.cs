namespace RefrigeratorApp.Products
{
    public class Fruit : Product
    {
        public Fruit(double quantity)
        {
            Id = 2;
            Name = "Fruit";
            Quantity = quantity;
            ExpiryDate = DateTime.Now.AddDays(7);
        }

        //add new constructor with quantity and expiry date
        public Fruit(double quantity, DateTime expiryDate)
        {
            Id = 2;
            Name = "Fruit";
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}

