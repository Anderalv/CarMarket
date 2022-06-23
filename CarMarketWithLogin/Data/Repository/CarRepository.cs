using System.Collections.Generic;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly ApplicationDbContext _appDbContent;

        public CarRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => _appDbContent.Cars
            .Include(x => x.Transmissions)
            .Include(x =>x.BodyType)
            .Include(x => x.DriveUnit)
            .Include(x => x.EngineType)
            .Include(x => x.Capacities)
            .Include(x => x.Imgs)
            .Include(x => x.Comments)
            .ToList();
        public Car GetCar(int carId) => Cars.FirstOrDefault(x => x.Id == carId);
    }
}