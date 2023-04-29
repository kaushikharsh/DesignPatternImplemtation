using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    //Group of Factory Methods ->  Abstract Factory : it return an object of its corresponding field or concrete class
    interface IUIFactory
    {
        object CreateButton();
        object CreateMenu();
        object CreateDropDown();
    }
}
