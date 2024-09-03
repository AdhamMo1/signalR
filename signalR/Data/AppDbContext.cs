using Microsoft.EntityFrameworkCore;
using signalR.Models;

namespace signalR.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
    }
}
