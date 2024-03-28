namespace AutomationPipeline
{
    class WaitCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Wait Time in Seconds:");
            int seconds = int.Parse(Console.ReadLine());

            System.Threading.Thread.Sleep(seconds * 1000);
            Console.WriteLine($"Waited for {seconds} seconds.");
        }

    }
}
