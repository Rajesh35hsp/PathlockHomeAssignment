namespace RefrigeratorApp.Products
{
    public class Vegetable : Product
    {
        public Vegetable(double quantity)
        {
            Id = 3;
            Name = "Vegetable";
            Quantity = quantity;
            ExpiryDate = DateTime.Now.AddDays(5);
        }

        public Vegetable(double quantity, DateTime expiryDate)
        {
            Id = 3;
            Name = "Vegetable";
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}
