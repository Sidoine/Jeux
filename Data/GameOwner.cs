namespace Jeux.Data
{
    public class GameOwner
    {
        public int Id { get; set; }
        public required int GameId { get; set; }
        public required int OwnerId { get; set; }
        public required Player Owner { get; set; }
    }
}
