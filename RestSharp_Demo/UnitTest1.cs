using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharp_Demo
{
 
    public class UnitTest1
    {
   
        public void TestMethod1()
        {
            /***
             * 1. Create the client
             * 2. Create the request
             * 3. Send the request using client
             * 4. Capture the Response
             */
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest();
        }
    }
}
