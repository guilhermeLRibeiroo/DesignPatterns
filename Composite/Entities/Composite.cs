using System.Text;

namespace Entities
{
    class Composite
        : Component
    {
        List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            StringBuilder sb = new StringBuilder("Branch(");

            foreach (var child in _children)
            {
                sb.Append(child.Operation());

                if (i != _children.Count - 1)
                    sb.Append("+");

                i++;
            }

            return sb.Append(")").ToString();
        }
    }
}
