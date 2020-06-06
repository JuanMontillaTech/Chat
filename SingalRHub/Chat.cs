using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace SingalRHub
{
    public class Chat :Hub
    {
        public Task send (string message)
        {
            System.Console.WriteLine(message);
            return Clients.Others.SendCoreAsync("Send", new[] { message });
        }
    }
}
