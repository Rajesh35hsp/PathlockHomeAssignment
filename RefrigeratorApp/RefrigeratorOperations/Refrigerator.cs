using RefrigeratorApp.Products;

namespace RefrigeratorApp.RefrigeratorOperations
{
    public class Refrigerator
    {
        private List<Product> products;
        private List<Purchase> purchases;
        private List<Consumption> consumptions;

        public Refrigerator()
        {
            products = new List<Product>();
            purchases = new List<Purchase>();
            consumptions = new List<Consumption>();
        }

        public void InsertProduct(Product product)
        {
            products.Add(product);
            purchases.Add(new Purchase
            {
                ProductId = product.Id,
                Quantity = product.Quantity,
                PurchaseDate = DateTime.Now
            });
        }

        public void RecordConsumption(int productId, double amountConsumed)
        {

            var product = products.OrderBy(p => p.ExpiryDate).FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                Console.WriteLine("No products found.");
                return;
            }
            if (product.Quantity < amountConsumed)
            {
                Console.WriteLine("Insufficient quantity.");
                return;
            }

            product.Quantity -= amountConsumed;
            consumptions.Add(new Consumption
            {
                ProductId = productId,
                AmountConsumed = amountConsumed,
                ConsumptionDate = DateTime.Now
            });
        }


        public void DisplayInformation(string title, List<string> items)
        {
            Console.WriteLine(title);
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }

        public void DisplayCurrentStatus()
        {
            var productsInfo = products.Select(p => $"Product Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Expiry Date: {p.ExpiryDate.ToShortDateString()}").ToList();
            DisplayInformation("Current Status:", productsInfo);
        }

        public void DisplayPurchases()
        {
            var purchasesInfo = purchases.Select(p => $"Product Id: {p.ProductId}, Quantity: {p.Quantity}, Purchase Date: {p.PurchaseDate.ToShortDateString()}").ToList();
            DisplayInformation("Purchases:", purchasesInfo);
        }

        public void DisplayConsumptions()
        {
            var consumptionsInfo = consumptions.Select(c => $"Product Id: {c.ProductId}, Amount Consumed: {c.AmountConsumed}, Consumption Date: {c.ConsumptionDate.ToShortDateString()}").ToList();
            DisplayInformation("Consumptions:", consumptionsInfo);
        }

        internal void DisplayExpiryAlert(int days)
        {
            var expiryAlert = products.Where(p => p.ExpiryDate.Date > DateTime.Now.AddDays(-1).Date && p.ExpiryDate.Date <= DateTime.Now.AddDays(days).Date)
                .Select(p => $"Product Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Expiry Date: {p.ExpiryDate.ToShortDateString()}").ToList();
            if (expiryAlert.Any())
                DisplayInformation("!!!!Expiry Alert!!!!! Products expiring with in next " + days + " days", expiryAlert);

        }

        internal void RemoveExpiredProducts()
        {
            var expiredProducts = products.Where(p => p.ExpiryDate.Date < DateTime.Now.Date).ToList();
            if (expiredProducts.Any())
            {
                DisplayInformation("Expired Products are removed from stock:", expiredProducts.Select(p => $"Product Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Expiry Date: {p.ExpiryDate.ToShortDateString()}").ToList());
                products.RemoveAll(p => p.ExpiryDate.Date < DateTime.Now.Date);

                Console.WriteLine("Please remove the expired products from the refrigerator!!!");

            }


        }
    }

}
