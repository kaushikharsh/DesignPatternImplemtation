using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class ConcreteReverseSort : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            List<int> listdata = data as List<int>;
            listdata.Sort();
            return listdata;
        }
    }
}
