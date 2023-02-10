namespace Mediator.Components
{
    public class Checkbox
        : BaseComponent
    {
        public void Check()
        {
            Console.WriteLine("Checkbox: check");
            _mediator.Notify(this, "check");
        }

        public void Uncheck()
        {
            Console.WriteLine("Checkbox: uncheck");
            _mediator.Notify(this, "uncheck");
        }
    }
}
