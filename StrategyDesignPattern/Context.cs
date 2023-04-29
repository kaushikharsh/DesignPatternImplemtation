using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Context
    {
        private IStrategy _strategy;
        public Context()
        {
                
        }
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void setStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void DoSorting()
        {
            //context doesn't know about which strategy you are follwoing for sorting
            var result = _strategy.DoAlgorithm(new List<int> { 1, 2, 30, 14, 5 });
            foreach(var x in result as List<int>)
            {
                Console.WriteLine(x);
            }
        }
    }
}
