namespace Prototype.Entities
{
    class Circle
        : ShapePrototype
    {
        public double Radius { get; set; }
        public Circle(int x, int y, string color, double radius) : base(x, y, color)
        {
            Radius = radius;
        }

        public override ShapePrototype Clone()
        {
            return new Circle(X, Y, Color, Radius);
        }
    }
}
