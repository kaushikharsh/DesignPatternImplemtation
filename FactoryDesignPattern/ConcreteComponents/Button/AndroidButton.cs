using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ConcreteComponents.Button
{
    class AndroidButton : IButton
    {
        public void changeSize()
        {
            Console.WriteLine("Android Button size is changed");
        }
    }
}
