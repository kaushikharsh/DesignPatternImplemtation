using FactoryDesignPattern.ConcreteComponents.Button;
using System;

namespace FactoryDesignPattern
{
    //Client Class to get the Flutter according to the type parameter
    class Program
    {
        static void Main(string[] args)
        {
            //Flutter create object
            //Flutter flutter = Flutter.getFlutter(UIParameter.IOS);
            Flutter flutter = Flutter.getFlutter(UIParameter.ANDROID);
            //Flutter flutter1 = Flutter.getFlutter(UIParameter.IOS);
            IUIFactory uIFactory = flutter.GetUIFactory();
            IButton b = (IButton)uIFactory.CreateButton();
            b.changeSize();
        }
    }
}
