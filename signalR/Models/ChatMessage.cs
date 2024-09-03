using System.ComponentModel.DataAnnotations;

namespace signalR.Models
{
    public class ChatMessage
    {
        public int id {  get; set; }
        public string message { get; set; }
        public string userName { get; set; }
    }
}
