using System.Collections.Generic;

namespace CarMarketWithLogin.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte Generation { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int TheHighestPrice { get; set; }
        public int TheLowestPrice { get; set; }
        public int RecommendPrice { get; set; }
        public List<Img> Imgs { get; set; }
        public List<Transmission> Transmissions { get; set; } = new List<Transmission>();
        public List<BodyType> BodyType { get; set; } = new List<BodyType>();
        public List<DriveUnit> DriveUnit { get; set; } = new List<DriveUnit>();
        public List<EngineType> EngineType { get; set; } = new List<EngineType>();
        public List<Capacity> Capacities { get; set; } = new List<Capacity>();
    }
}