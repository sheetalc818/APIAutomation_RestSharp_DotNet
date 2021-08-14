
/**
 * Purpose : Demonstrate the RestSharp for Spotify Get-Request
 * Author  : Sheetal Chaudhari
 * Date    : 14/08/2021
 */


using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;

namespace RestSharp_Demo.RestGetEndPoint
{
    [TestClass]
    public class TestGetEndPoint
    {
        private string MyToken = "Bearer BQDp6wb0QB66vh0IwJ3wNv5LwS07CYgm5c0wEwUDbi0EPgqH" +
                                 "S1UvR3cVXiPxjmUj7Ym52WgjrS8Q_hEle33mwLKLXrlXQoQimz8b" +
                                 "_xzNijVA5sTci675c7UwqMNOiYjvbZ0lbFJ0IlizLzjpF2sX1p" +
                                 "ULJj6yGOXm3Cg5vWfrAwuh7wirkpP_Ofyb1mL0PBZTZvb6aO_YweZSRiUghCyLgdEOpfKFtT1HGlMQZ6sxmshWtV90NA9_" +
                                 "qwn7OImQ_b3kXC3A168PUnHkjI_gge7G0eytJF7lS2_pKTNL5bhO";
        private string getUrl = "https://api.spotify.com/v1/me";
        private static IRestResponse Response { get; set; }

        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            
            restRequest.AddHeader("Authorization", "token " + MyToken);
            Response = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
            Console.WriteLine(JsonConvert.SerializeObject(Response.Content, Formatting.Indented));
        }
    }
}
