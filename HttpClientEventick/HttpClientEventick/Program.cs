
using System.Net;
using System;
using Newtonsoft.Json;
using System.IO;
using HttpClientEventick.Response;
using HttpClientEventick.Response.ParticipantsResponse;

namespace HttpClientEventick
{
    class MainClass
    {
        /* public static void Main(string[] args)
        {
            var teste = ListEvents();
        }
        */

        public static EventsResponse ListEvents()
        {
           var request = (HttpWebRequest)WebRequest.Create("https://api.sympla.com.br/public/v3/events");
           request.Method = "GET";

           request.Headers["s_token"] = "c1550a463a9b91d2e01ca8320460743fb22a7360e71aa3354db36199599aca0c";//Adding AuthToken to the Request Header

           var response = (HttpWebResponse)request.GetResponse();
           using (var streamReader = new StreamReader(response.GetResponseStream()))
           {
              var jsonResponse = streamReader.ReadToEnd();

              var result = JsonConvert.DeserializeObject<EventsResponse>(jsonResponse);

              return result;
           }
        }

        public static ParticipantsResponse ListParticipants(int eventid)
        {
            var url = String.Format("https://api.sympla.com.br/public/v3/events/{0}/participants", eventid);

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            request.Headers["s_token"] = "c1550a463a9b91d2e01ca8320460743fb22a7360e71aa3354db36199599aca0c";//Adding AuthToken to the Request Header

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResponse = streamReader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<ParticipantsResponse>(jsonResponse);

                return result;
            }
        }
    }
}