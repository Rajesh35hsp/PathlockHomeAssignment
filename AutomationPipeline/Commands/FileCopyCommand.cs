namespace AutomationPipeline
{
    class FileCopyCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Source File Path:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Enter Destination File Path:");
            string destinationPath = Console.ReadLine();

            sourcePath = sourcePath.Trim('\"');
            destinationPath = destinationPath.Trim('\"');

            File.Copy(sourcePath, destinationPath);
            Console.WriteLine("File copied successfully!");
        }

    }
}
