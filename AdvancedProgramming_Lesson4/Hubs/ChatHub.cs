using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using AdvancedProgramming_Lesson4.Models;
using AdvancedProgramming_Lesson4.Data;

namespace AdvancedProgramming_Lesson4.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string user, string message)
        {
            var chatMessage = new ChatMessage(user, message);
            _context.Add(chatMessage);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
