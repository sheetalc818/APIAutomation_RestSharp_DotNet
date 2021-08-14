
/**
 * Purpose : Demonstrate the RestSharp for Spotify Post-Request
 * Author  : Sheetal Chaudhari
 * Date    : 14/08/2021
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;

namespace RestSharp_Demo.RestPostEndPoint
{
    [TestClass]
    public class TestPostEndPoint
    {
        private string myToken = "Bearer BQCPHOz9HxRh13L0dAwLDMIi7BIt13mrS3-9_XJ1MTCUYs--MB0_jPX6g1-Rl_" +
            "P7tms28BXcVZ2RQSxQSaYwXImleyUbg9gVoiWvOWuHUJWXTCLchIuU9qaxdvFZBimWfUyHnJADJl9QWR-" +
            "npxhn4VVbkasYAU2e5kkncLUFgRdlVoGliTuh-FKa-kl8CJyendYtTs8_7GDxNzX3Z5tEJWBF_" +
            "coxzNjmpmxAZuhBbSlEzojmr66O0-qTezruiOUHDsRQmgZKQuzIeecy3dIQ1kXpiTU1mJI--" +
            "fTH3um2";

        private string postUrl = "https://api.spotify.com/v1/users/miq9x438ysuedi1io43rz0awv/playlists";
        private static IRestResponse restResponse { get; set; }
        private string content = "application/json";

        [TestMethod]
        public void TestPostWithJsonData()
        {
            string JsonData = "{" +
                              "\"name\":\"Sheetal's fav Playlist\"," +
                              "\"description\":\"New playlist description\"," +
                              "\"public\": \"false\"" + 
                              "}";

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(postUrl);

            restRequest.AddHeader("Content-Type", content);
            restRequest.AddHeader("Accept", content);
            restRequest.AddHeader("Authorization", "token " + myToken);
            restRequest.AddJsonBody(JsonData);

            restResponse = restClient.Post(restRequest);

            Assert.AreEqual(201, (int)restResponse.StatusCode);
            //Console.WriteLine(JsonConvert.SerializeObject(restResponse.Content, Formatting.Indented));
            Console.WriteLine("Response : " + restResponse.Content);
        }
    }
}
