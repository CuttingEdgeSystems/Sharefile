using System;
using Xunit;
using System.Net;

namespace Sharefile.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HttpWebRequest myReq= (HttpWebRequest)WebRequest.Create(" https://azapp-ces-website.azurewebsites.net/");
            
            HttpWebResponse  response = (HttpWebResponse)myReq.GetResponse();
            System.Console.WriteLine(response.StatusCode);


            Assert.NotNull(response);
           
            
            

        }
    }
}
