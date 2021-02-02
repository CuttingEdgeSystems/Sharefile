using System;
using System.IO;
using System.Collections.Generic;
using ShareFile.Api.Client;
using System.Net;



namespace sharefileConnect
{
    public class Program
    {
              static void Main(string[] args)
       {

           HttpWebRequest myReq= (HttpWebRequest)WebRequest.Create(" https://azapp-ces-website.azurewebsites.net/");
            myReq.Method= "GET";
            HttpWebResponse  myRep = (HttpWebResponse)myReq.GetResponse();

            var responseStream = myRep.GetResponseStream();

            System.Console.WriteLine(myRep.StatusCode);
            using (var reader= new StreamReader(myRep.GetResponseStream()))
            {
                 String body = reader.ReadToEnd();
                 System.Console.WriteLine(body);
 
                
                
            }
            
            

        

       }

    
   
    

    }
}