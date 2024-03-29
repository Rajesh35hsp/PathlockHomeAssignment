namespace RefrigeratorApp.RefrigeratorOperations
{
    public class Consumption
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double AmountConsumed { get; set; }
        public DateTime ConsumptionDate { get; set; }
    }
}
