using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using consumeEventick.Models.EventsResponse;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace consumeEventick.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
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

                return View(result);

            }
        }
    }
}
