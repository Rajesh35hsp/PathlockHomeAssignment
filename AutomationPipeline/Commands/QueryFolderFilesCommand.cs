namespace AutomationPipeline
{
    class QueryFolderFilesCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Folder Path:");
            string folderPath = Console.ReadLine();
            folderPath = folderPath.Trim('\"');

            string[] files = Directory.GetFiles(folderPath);
            Console.WriteLine("\nFiles in the folder:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }

}
