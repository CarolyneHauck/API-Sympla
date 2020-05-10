using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using consumeEventick.Models;
using System;
using consumeEventick.Models.EventsResponse;
using consumeEventick.Models.ParticipantsResponse;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace consumeEventick.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://api.sympla.com.br/public/v3/events");
            request.Method = "GET";

            request.Headers["s_token"] = "c1550a463a9b91d2e01ca8320460743fb22a7360e71aa3354db36199599aca0c";//Adding AuthToken to the Request Header

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResponse = streamReader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<EventsResponse>(jsonResponse);

                return View(new EventsResponse { Data = result.Data, Pagination = result.Pagination });
            }
        }

        public IActionResult Privacy(int id)
        {
            var url = String.Format("https://api.sympla.com.br/public/v3/events/{0}/participants", id);

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            request.Headers["s_token"] = "c1550a463a9b91d2e01ca8320460743fb22a7360e71aa3354db36199599aca0c";//Adding AuthToken to the Request Header

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResponse = streamReader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<ParticipantsResponse>(jsonResponse);

                return View(new ParticipantsResponse { Data = result.Data, Pagination = result.Pagination });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
