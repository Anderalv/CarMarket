namespace CarMarketWithLogin.Models
{
    public class BookMark
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public User User { get; set; }
    }
}