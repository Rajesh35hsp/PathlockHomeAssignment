using RefrigeratorApp.Products;
using RefrigeratorApp.RefrigeratorOperations;

namespace RefrigeratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refrigerator refrigerator = new Refrigerator();

            //Add some products to the refrigerator for testing
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 2, DateTime.Now.AddDays(-1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 5, DateTime.Now));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 3, DateTime.Now.AddDays(1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 3, DateTime.Now.AddDays(2)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 3, DateTime.Now.AddDays(3)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(1, 10, DateTime.Now.AddDays(6)));

            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 2, DateTime.Now.AddDays(-1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 5, DateTime.Now));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 3, DateTime.Now.AddDays(1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 3, DateTime.Now.AddDays(2)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 3, DateTime.Now.AddDays(3)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(2, 10, DateTime.Now.AddDays(6)));

            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 2, DateTime.Now.AddDays(-1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 5, DateTime.Now));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 3, DateTime.Now.AddDays(1)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 3, DateTime.Now.AddDays(2)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 3, DateTime.Now.AddDays(3)));
            refrigerator.InsertProduct(ProductFactory.CreateProduct(3, 10, DateTime.Now.AddDays(6)));


            refrigerator.DisplayExpiryAlert(2);

            //remove expired products from the refrigerator and display message to remove those products
            refrigerator.RemoveExpiredProducts();

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Please enter an operation:");
                Console.WriteLine("1. Insert product");
                Console.WriteLine("2. Record consumption");
                Console.WriteLine("3. Display purchases");
                Console.WriteLine("4. Display consumptions");
                Console.WriteLine("5. Display current status");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Available Products");
                        Console.WriteLine("1. Milk");
                        Console.WriteLine("2. Fruit");
                        Console.WriteLine("3. Vegetable");
                        Console.WriteLine();

                        Console.WriteLine("Enter the product ID:");
                        int productId = int.Parse(Console.ReadLine());

                        if (productId < 1 || productId > 3)
                        {
                            Console.WriteLine("Invalid product id. Please try again.");
                            continue;
                        }

                        Console.WriteLine("Enter the product quantity:");
                        double quantity = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the expiry date (optional, else default days for product will be added.):");
                        DateTime.TryParse(Console.ReadLine(), out DateTime expiryDate);

                        if (expiryDate == DateTime.MinValue)
                        {
                            refrigerator.InsertProduct(ProductFactory.CreateProduct(productId, quantity));
                        }
                        else
                        {
                            refrigerator.InsertProduct(ProductFactory.CreateProduct(productId, quantity, expiryDate));
                        }

                        break;

                    case "2":
                        Console.WriteLine("Enter the product ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the consumption quantity:");
                        double consumption = double.Parse(Console.ReadLine());
                        refrigerator.RecordConsumption(id, consumption);
                        break;

                    case "3":
                        refrigerator.DisplayPurchases();
                        break;

                    case "4":
                        refrigerator.DisplayConsumptions();
                        break;

                    case "5":
                        refrigerator.DisplayCurrentStatus();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
