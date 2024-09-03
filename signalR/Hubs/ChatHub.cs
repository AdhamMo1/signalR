using Microsoft.AspNetCore.SignalR;
using signalR.Data;
using signalR.Models;

namespace signalR.Hubs
{
    public class ChatHub : Hub
    {
        private AppDbContext _context;
        public ChatHub(AppDbContext context)
        {
            _context = context;
        }
        public void sendMessage(string name,string message)
        {
            // save in db
            var chat = new ChatMessage { message = message,userName = name };
            _context.ChatMessages.Add(chat);
            _context.SaveChanges();
            // broadcasting to all online clients
            Clients.All.SendAsync("NewMessage",name, message);
        }
    }
}
