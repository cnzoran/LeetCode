using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CandyGrammar
{
    internal class AwaitOperator
    {
        public static async Task Main()
        {
            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(Main)}: Launched downloading.");

            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");
        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

            HttpClient client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
            return content.Length;
        }
    }
}
