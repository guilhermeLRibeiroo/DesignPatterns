using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context is sorting data using the current strategy.");
            var result = _strategy.SortCollection(new List<string> { "a", "c", "b", "e", "d" });

            string resultStr = string.Join(", ", result as List<string>);

            Console.WriteLine($"Result: {resultStr}.");
        }
    }
}
