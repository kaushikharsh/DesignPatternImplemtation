using FactoryDesignPattern.ConcreteComponents.Button;
using FactoryDesignPattern.ConcreteComponents.DropDown;
using FactoryDesignPattern.ConcreteComponents.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    //Other Concrete Class to get concrete IOS implementation
    class IosUIFactory : IUIFactory
    {
        public object CreateButton()
        {
            return new IosButton();
        }

        public object CreateDropDown()
        {
            return new IosDropDown();
        }

        public object CreateMenu()
        {
            return new IosMenu();
        }
    }
}
