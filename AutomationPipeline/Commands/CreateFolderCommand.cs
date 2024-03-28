namespace AutomationPipeline
{
    class CreateFolderCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Parent Folder Path:");
            string parentFolderPath = Console.ReadLine();

            Console.WriteLine("Enter New Folder Name:");
            string newFolderName = Console.ReadLine();

            Directory.CreateDirectory(Path.Combine(parentFolderPath, newFolderName));
            Console.WriteLine("Folder created successfully!");
        }
    }

}
