namespace CarMarketWithLogin.Models
{
    public class BookMark
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
    }
}