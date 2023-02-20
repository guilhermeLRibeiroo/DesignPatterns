namespace TemplateMethod
{
    public class ConcreteClassA
        : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClassA implemented first required operation.");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClassA implemented the second required operation.");
        }
    }
}
