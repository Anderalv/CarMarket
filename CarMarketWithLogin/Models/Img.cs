namespace CarMarketWithLogin.Models
{
    public class Img
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}