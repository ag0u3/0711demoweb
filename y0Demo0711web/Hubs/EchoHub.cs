using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace y0Demo0711web.Hubs
{
    [HubName("Echo")]
    public class EchoHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string text)
        {
            Clients.All.Receive(text);
        }
    }
}