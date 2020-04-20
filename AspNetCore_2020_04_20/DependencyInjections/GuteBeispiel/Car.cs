using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjections.GuteBeispiel
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public void Show()
        {
            
        }
    }
}
