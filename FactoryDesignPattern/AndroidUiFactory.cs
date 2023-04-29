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
    //Specific class that implements the Factory Methods to get the Object of specific Concrete Classes via Interface IUIFactory
    class AndroidUiFactory : IUIFactory
    {
        public object CreateButton()
        {
            return new AndroidButton();
        }

        public object CreateDropDown()
        {
            return new AndroidDropDown();
        }

        public object CreateMenu()
        {
            return new AndroidMenu();
        }
    }
}
