using System.Collections.Generic;

namespace CarMarketWithLogin.Models
{
    public class Transmission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}