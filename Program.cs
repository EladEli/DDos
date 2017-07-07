using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DDos
{
    internal class Program
    {
        private static void Main()
        {
            var url = new Uri("http://localhost:8888/");
            Console.WriteLine("Enter http client's number:");
            var numberOfClients = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i <= numberOfClients; i++)
            {
                var client = new WebClient();
                client.DownloadStringAsync(url);
                client.Dispose();
            }
        }
    }
}
