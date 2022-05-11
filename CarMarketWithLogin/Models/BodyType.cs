using System.Collections.Generic;

namespace CarMarketWithLogin.Models
{
    public class BodyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}