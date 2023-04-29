using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.setStrategy(new ConcreteSimpleSort());
            context.DoSorting();

            context.setStrategy(new ConcreteReverseSort());
            context.DoSorting();
        }

    }
}
