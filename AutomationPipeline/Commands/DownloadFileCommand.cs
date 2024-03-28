using System.Net;

namespace AutomationPipeline
{
    class DownloadFileCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Enter Source URL:");
            string url = Console.ReadLine();
            url = url.Trim('\"');

            Console.WriteLine("Enter Output File Path:");
            string outputPath = Console.ReadLine();
            outputPath = outputPath.Trim('\"');

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, outputPath);
            }
            Console.WriteLine("File downloaded successfully!");
        }
    }

}
