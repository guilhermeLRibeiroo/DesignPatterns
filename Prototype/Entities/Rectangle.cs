namespace Prototype.Entities
{
    class Rectangle
        : ShapePrototype
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public override ShapePrototype Clone()
        {
            return new Rectangle(X, Y, Color, Width, Height);
        }
    }
}
