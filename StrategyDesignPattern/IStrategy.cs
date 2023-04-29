using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
