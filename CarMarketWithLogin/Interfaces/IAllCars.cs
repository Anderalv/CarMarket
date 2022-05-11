using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        Car GetCar(int carId);
    }
}