using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ConcreteComponents.Button
{
    class IosButton : IButton
    {
        public void changeSize()
        {
            Console.WriteLine("Ios Button size is changed");
        }
    }
}
