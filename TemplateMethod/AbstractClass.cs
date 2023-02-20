namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOpertation1();
            RequiredOperation1();
            BaseOpertation2();
            Hook1();
            RequiredOperation2();
            BaseOpertation3();
            Hook2();
        }

        protected void BaseOpertation1()
        {
            Console.WriteLine("AbstractClass does a lot of the work");
        }

        protected void BaseOpertation2()
        {
            Console.WriteLine("AbstractClass can also let subclasses override some operations");
        }

        protected void BaseOpertation3()
        {
            Console.WriteLine("but AbsctractClass is doing most of the work anyway");
        }

        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
