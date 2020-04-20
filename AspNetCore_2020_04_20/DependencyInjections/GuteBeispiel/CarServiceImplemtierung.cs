using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjections.GuteBeispiel
{
    public class CarServiceImplemtierung
    {
        private ICarService carServie;

        public CarServiceImplemtierung()
        {
            carServie = new CarService();
        }

        public void MachWas()
        {
            ICar car = new Car();
            car.Brand = "VW";
            car.Color = "Yellow";

            ICar mockCar = new MockCar();
            car.Brand = "Testmarke";
            car.Color = "Testfarbe";

            carServie.BuyCar(car);
        }
    }
}
