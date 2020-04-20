using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjections.AntiBeispiel
{
    public class CarService
    {
        public void BuyCar(Car car)
        {
            car.Show();
        }
    }
}
