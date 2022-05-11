using System.Collections.Generic;

namespace CarMarketWithLogin.Models
{
    public class EngineType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}