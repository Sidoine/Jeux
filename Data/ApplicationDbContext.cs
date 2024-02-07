using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jeux.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public required DbSet<Game> Games { get; set; }
        public required DbSet<Player> Players { get; set; }
        public required DbSet<Session> Sessions { get; set; }
        public required DbSet<SessionPlayer> SessionPlayers { get; set; }
    }
}