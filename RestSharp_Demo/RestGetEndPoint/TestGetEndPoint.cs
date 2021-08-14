
/**
 * Purpose : Demonstrate the RestSharp for Spotify Get-Request
 * Author  : Sheetal Chaudhari
 * Date    : 14/08/2021
 */
using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharp_Demo.RestGetEndPoint
{
    [TestClass]
    public class TestGetEndPoint 
    {
        private string myToken = "Bearer BQCPHOz9HxRh13L0dAwLDMIi7BIt13mrS3-9_XJ1MTCUYs--MB0_jPX6g1-Rl_" +
            "P7tms28BXcVZ2RQSxQSaYwXImleyUbg9gVoiWvOWuHUJWXTCLchIuU9qaxdvFZBimWfUyHnJADJl9QWR-" +
            "npxhn4VVbkasYAU2e5kkncLUFgRdlVoGliTuh-FKa-kl8CJyendYtTs8_7GDxNzX3Z5tEJWBF_coxzNjmpmxAZuhBbSlEzojmr66O0-" +
            "qTezruiOUHDsRQmgZKQuzIeecy3dIQ1kXpiTU1mJI--fTH3um2";

        private string getUrl = "https://api.spotify.com/v1/me";
        private static IRestResponse restResponse { get; set; }

        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            
            restRequest.AddHeader("Authorization", "token " + myToken);
            restResponse = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code : " + restResponse.StatusCode);
                Console.WriteLine("Response : " + restResponse.Content);
            }

            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);

            
            //Console.WriteLine(JsonConvert.SerializeObject(restResponse.Content, Formatting.Indented));
        }
    }
}
