using Visitor.Components;

namespace Visitor.Visitors
{
    public class ConcreteVisitorB
        : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} - ConcreteVisitorB");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} - ConcreteVisitorB");
        }
    }
}
