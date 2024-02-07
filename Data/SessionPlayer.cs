namespace Jeux.Data
{
    public class SessionPlayer
    {
        public int Id { get; set; }
        public required int SessionId { get; set; }
        public required int PlayerId { get; set; }
        public required Player Player { get; set; }
    }
}
