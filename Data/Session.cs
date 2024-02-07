namespace Jeux.Data
{
    public class Session
    {
        public required int Id { get; set; }
        public required DateTime Date { get; set; }
        public required int GameId { get; set; }
        public required Game Game { get; set; }
    }
}
