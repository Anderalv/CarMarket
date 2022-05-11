using System.Collections.Generic;

namespace CarMarketWithLogin.Models
{
    public class Capacity
    {
        public int Id { get; set; }
        public double Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}