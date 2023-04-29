using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.PracticalFactory
{
    class UIFactoryFactory
    {
        //Practical Factory ->  Class X having methods to return X on the basis of the parameter
        public static IUIFactory GetUIFactoryForName(UIParameter uIParameter)
        {
            switch(uIParameter)
            {
                case UIParameter.ANDROID: 
                    return new AndroidUiFactory();
                case UIParameter.IOS: 
                    return new IosUIFactory();
            };
            return null;
        }
    }
}
