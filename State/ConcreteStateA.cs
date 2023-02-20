namespace State
{
    public class ConcreteStateA
        : State
    {
        public override void Something()
        {
            Console.WriteLine($"\nConcreteStateA handles {nameof(Something)}.");
            Console.WriteLine($"ConcreteStateA will change the state of the context.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void SomethingElse()
        {
            Console.WriteLine($"\nConcreteStateA handles {nameof(SomethingElse)}.");
        }
    }
}
