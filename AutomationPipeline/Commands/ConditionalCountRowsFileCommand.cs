namespace AutomationPipeline
{
    public class ConditionalCountRowsFileCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Source File Path:");
            string filePath = Console.ReadLine();
            filePath = filePath.Trim('\"');

            //check if file is text file , if not console error message and return
            if (!filePath.EndsWith(".txt"))
            {
                Console.WriteLine("File is not a text file. Please try again with a valid text file path.");
                return;
            }

            Console.WriteLine("Enter String to Search in Rows:");
            string searchString = Console.ReadLine();

            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.Contains(searchString))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Number of rows containing '{searchString}' in the file: {count}");
        }
    }
}
