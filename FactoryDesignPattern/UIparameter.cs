using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    //Enum to handle Type Safety and in future something will be added , just add here and create respective component class
    //lets say webButton,WebDropdown,WebMenu , also Create WebUIFactory to get object of this in IUIFactoty
    enum UIParameter
    {
        ANDROID,
        IOS
    }
}
