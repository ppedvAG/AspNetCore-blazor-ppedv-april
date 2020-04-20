using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjections.GuteBeispiel
{
    public  class CarService : ICarService
    {
        public void BuyCar(ICar car)
        {
            car.Show();
        }
    }
}
