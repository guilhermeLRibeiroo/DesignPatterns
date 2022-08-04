using Prototype.Entities;

var rectangle = new Rectangle(0, 10, "Red", 25, 25);
var rectangleClone = (Rectangle)rectangle.Clone();

Console.WriteLine("Is Rectangle equal Rectangle Clone? {0}\n", rectangle.Equals(rectangleClone));

var circle = new Circle(10, 15, "Blue", 14.7);
var circleClone = (Circle)circle.Clone();

Console.WriteLine("Circle X: {0}", circle.X);
Console.WriteLine("Circle Y: {0}", circle.Y);
Console.WriteLine("Circle Color: {0}", circle.Color);
Console.WriteLine("Circle Radius: {0}\n", circle.Radius);

Console.WriteLine("Circle Clone X: {0}", circleClone.X);
Console.WriteLine("Circle Clone Y: {0}", circleClone.Y);
Console.WriteLine("Circle Clone Color: {0}", circleClone.Color);
Console.WriteLine("Circle Clone Radius: {0}", circleClone.Radius);