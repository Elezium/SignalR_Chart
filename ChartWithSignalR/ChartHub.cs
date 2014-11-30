using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;


namespace ChartWithSignalR
{
    public class ChartHub : Hub
    {

        public override Task OnConnected()
        {
            return Clients.All.Data(RandomData());            
        }

        public Task SendData()
        {
            return Clients.All.Data(RandomData());
        }

        private int RandomData()
        {
            Random r = new Random();
            return r.Next(-10, 10);
        }

    }
}