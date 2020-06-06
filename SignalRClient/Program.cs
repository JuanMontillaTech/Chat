using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace SignalRClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/ChatHub")
                .Build();
            connection.On<string>("Send", (message) =>
            {
                Console.WriteLine("Recibido:");
                Console.WriteLine(message);
            });
            connection.StartAsync().Wait();
            while (true)
            {
                Console.WriteLine("Escriba un mensaje:");
                var message = Console.ReadLine();
                connection.SendAsync("Send", message);
            }
        }
    }
}
