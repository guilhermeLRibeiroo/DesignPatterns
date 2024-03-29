﻿using Visitor.Visitors;

namespace Visitor.Components
{
    public class ConcreteComponentA
        : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodOfConcreteComponentA()
        {
            return $"{nameof(ConcreteComponentA)}: exclusive method A";
        }
    }
}
