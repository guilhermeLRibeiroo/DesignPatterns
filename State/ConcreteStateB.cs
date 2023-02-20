namespace State
{
    public class ConcreteStateB
        : State
    {
        public override void Something()
        {
            Console.WriteLine($"\nConcreteStateB handles {nameof(Something)}.");
        }

        public override void SomethingElse()
        {
            Console.WriteLine($"\nConcreteStateB handles {nameof(SomethingElse)}.");
            Console.WriteLine($"ConcreteStateB will change the state of the context.");
            this._context.TransitionTo(new ConcreteStateA());
        }
    }
}
