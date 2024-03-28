namespace AutomationPipeline
{
    class FileDeleteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter File Path to Delete:");
            string filePath = Console.ReadLine();

            filePath = filePath.Trim('\"');

            File.Delete(filePath);
            Console.WriteLine("File deleted successfully!");
        }
    }

}
