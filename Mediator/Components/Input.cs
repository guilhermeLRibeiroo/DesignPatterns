namespace Mediator.Components
{
    public class Input
        : BaseComponent
    {
        public void Hide()
        {
            Console.WriteLine("Input is hidden.");
            _mediator.Notify(this, "isHidden");
        }

        public void Show()
        {
            Console.WriteLine("Input is not hidden.");
            _mediator.Notify(this, "isNotHidden");
        }
    }
}
