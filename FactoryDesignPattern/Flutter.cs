using FactoryDesignPattern.PracticalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    //Singleton Class 
    class Flutter
    {   
        private static UIParameter _uIParameter ;
        private static Flutter _flutterInstance;
        private static readonly object _lock = new object();
        private Flutter(UIParameter uIParameter)
        {
            _uIParameter = uIParameter;
        }
        public static Flutter getFlutter(UIParameter uIParameter)
        {
            if(_flutterInstance==null)
            {
                lock(_lock)
                {
                    if (_flutterInstance == null)
                        _flutterInstance = new Flutter(uIParameter);
                }
            }
            return _flutterInstance;
        }
        public void setbutton()
        {
            //Just simple Methods we don't have any object creation for these method, these are not represent factory method
            //these are just specific method and those are not depending on the object of some other Interface or classes or 
            //different Implementation
        }
        public void SetMenu()
        {

        }
        //Abstract Factory is defined below -> previously Flutter is having responsiblity to get the Object in IUIFactory 
        //According to the various Parameter, to solve this Problem because Flutter is directly depending on AndroidFactory
        //so this is a tight coupling between two classes, so Solution is Practical Factory 
        //Practical Factory -> line 60
        /*public IUIFactory GetUIfactory(string parameter)
        {
            if(parameter.Equals("ANDROID"))
            {
                return new AndroidUiFactory();
            }
            else if(parameter.Equals("IOS"))
            {
                return new IosUIFactory();
            }
            return null;
        }*/
        public IUIFactory GetUIFactory()
        {
            //We created another class , so that we can get the Object of X let's say from the Class X having Methods ,and these
            //methods return the object of corresponding class according to its Paramter that we have in business requirements
            return UIFactoryFactory.GetUIFactoryForName(_uIParameter); 
        }
    }
}
