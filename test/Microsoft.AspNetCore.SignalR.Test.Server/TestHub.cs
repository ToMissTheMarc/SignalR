using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Test.Server
{
    public class TestHub : Hub
    {
        public string Echo(string message)
        {
            return message;
        }

        public void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }

        public Task InvokeWithString(string message)
        {
            return Clients.Client(Context.Connection.ConnectionId).InvokeAsync("Message", message);
        }
    }
}
