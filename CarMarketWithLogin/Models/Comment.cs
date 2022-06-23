using System.ComponentModel.DataAnnotations.Schema;

namespace CarMarketWithLogin.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Data { get; set; }
        public string Tenure { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
    }
}