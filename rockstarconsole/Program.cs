using System;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace rockstarconsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            HttpClient httpClient = new HttpClient();

            // Send a request to fetch data.
            string requestAddress = "http://localhost:5000/rockstar/faith";
            var song = await httpClient.GetStringAsync($"{requestAddress}");
            Console.WriteLine(song);
        }
    }
}
