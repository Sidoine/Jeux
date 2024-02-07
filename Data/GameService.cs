using Microsoft.EntityFrameworkCore;

namespace Jeux.Data
{
    public class GameService
    {
        private ApplicationDbContext _db;

        public GameService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Game[]> GetAll()
        {
               return _db.Games.Include(x => x.Owners).ThenInclude(y => y.Owner).ToArrayAsync();
        }

        public Task<Game?> Get(int id)
        {
               return _db.Games.Include(x => x.Owners).ThenInclude(y => y.Owner).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Game[]> GetForPlayer(int playerId)
        {
               return _db.Games.Include(x => x.Owners).ThenInclude(y => y.Owner).Where(x => x.Owners.Any(y => y.OwnerId == playerId)).ToArrayAsync();
        }

        public Task Add(Game game)
        {
            _db.Games.Add(game);
            return _db.SaveChangesAsync();
        }
    }
}
