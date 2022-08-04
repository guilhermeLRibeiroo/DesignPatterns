namespace Prototype.Entities
{
    abstract class ShapePrototype
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public ShapePrototype(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract ShapePrototype Clone();
    }
}
