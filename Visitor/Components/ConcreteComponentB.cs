using Visitor.Visitors;

namespace Visitor.Components
{
    public class ConcreteComponentB
        : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return $"{nameof(ConcreteComponentB)}: special method B";
        }
    }
}
