using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rockstarmvc.Models;

//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
using System.Net;
using System.IO;
using System.Text;

namespace rockstarmvc.Controllers
{
    public class RockStarController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RockStarController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Faith()
        {
            return View();
        }

        public IActionResult Faith2()
        {
            return View();
        }

        public IActionResult Faith3()
        {
            // var client = new HttpClient();

            // // Send a request to fetch data.
            // string requestAddress = "http://localhost:5000/rockstar/faith";
            // var request = new HttpRequestMessage(HttpMethod.Get, requestAddress);
            // var response = client.(request);
            // return response;

            var url = "http://localhost:5000/rockstar/faith";
            var request = WebRequest.CreateHttp(url);
            request.Method = "GET";

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                // Get the stream associated with the response
                using (var responseStream = response.GetResponseStream())
                {
                    // Get a reader capable of reading the response stream
                    using (var myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        // Read stream content as string
                        var responseHtml = myStreamReader.ReadToEnd();
                        
                        // Assuming the response is in JSON format, deserialize it
                        // creating an instance of TData type (generic type declared before).
                        //data = JsonConvert.DeserializeObject<TData>(responseJSON);

                        //Console.WriteLine(responseHtml);
                        ViewData["html"] = responseHtml;
                        return View();
                    }
                }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
