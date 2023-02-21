using Visitor.Components;

namespace Visitor.Visitors
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);
        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
