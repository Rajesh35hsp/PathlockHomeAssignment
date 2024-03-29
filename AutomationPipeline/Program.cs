namespace AutomationPipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Automation Pipeline!!");

            Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>
            {
                {"File Copy", new FileCopyCommand()},
                {"File Delete", new FileDeleteCommand()},
                {"Query Folder Files", new QueryFolderFilesCommand()},
                {"Create Folder", new CreateFolderCommand()},
                {"Download File", new DownloadFileCommand()},
                {"Wait", new WaitCommand()},
                {"Conditional Count Rows File", new ConditionalCountRowsFileCommand()}
            };

            while (true)
            {
                Console.WriteLine("\nAvailable Commands:");
                foreach (var command in commands.Keys)
                {
                    Console.WriteLine(command);
                }

                Console.WriteLine("\nEnter the command (type 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;
                
                //do case insensitive check for command
                input = input.ToLower();

                if (commands.ContainsKey(input))
                {
                    commands[input].Execute();
                }
                else
                {
                    Console.WriteLine("Invalid command! Please try again.");
                }
            }
        }
    }
}
