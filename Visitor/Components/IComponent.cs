using Visitor.Visitors;

namespace Visitor.Components
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
