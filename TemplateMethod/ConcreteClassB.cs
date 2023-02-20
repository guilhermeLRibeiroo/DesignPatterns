namespace TemplateMethod
{
    public class ConcreteClassB
        : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClassB implemented first required operation.");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClassB implemented the second required operation.");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClassB overrided Hook1.");
        }
    }
}
