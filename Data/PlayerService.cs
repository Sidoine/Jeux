using Microsoft.EntityFrameworkCore;

namespace Jeux.Data
{
    public class PlayerService
    {
        private readonly ApplicationDbContext _dbContext;

        public PlayerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Player[]> GetAll()
        {
            return _dbContext.Players.ToArrayAsync();
        }

        public Task<Player?> Get(int id)
        {
            return _dbContext.Players.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task Add(Player player)
        {
            _dbContext.Players.Add(player);
            return _dbContext.SaveChangesAsync();
        }
    }
}
