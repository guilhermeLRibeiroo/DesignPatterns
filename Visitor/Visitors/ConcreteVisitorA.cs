using Visitor.Components;

namespace Visitor.Visitors
{
    public class ConcreteVisitorA
        : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} - ConcreteVisitorA");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} - ConcreteVisitorA");
        }
    }
}
