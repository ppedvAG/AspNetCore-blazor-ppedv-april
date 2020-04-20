using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjections.GuteBeispiel
{
    public class MockService : ICarService
    {
        public void BuyCar(ICar car)
        {
            //MockTest
        }
    }
}
