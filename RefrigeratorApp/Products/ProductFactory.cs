using System;

namespace RefrigeratorApp.Products
{
    public class ProductFactory
    {
        public static Product CreateProduct(int id, double quantity)
        {
            switch (id)
            {
                case 1:
                    return new Milk(quantity);
                case 2:
                    return new Fruit(quantity);
                case 3:
                    return new Vegetable(quantity);
                default:
                    throw new ArgumentException("Invalid product id");
            }
        }

        // Overload with DateTime expiryDate
        public static Product CreateProduct(int id, double quantity, DateTime expiryDate)
        {
            switch (id)
            {
                case 1:
                    return new Milk(quantity, expiryDate);
                case 2:
                    return new Fruit(quantity, expiryDate);
                case 3:
                    return new Vegetable(quantity, expiryDate);
                default:
                    throw new ArgumentException("Invalid product id");
            }
        }
    }
}
