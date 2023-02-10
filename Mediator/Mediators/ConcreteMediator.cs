using Mediator.Components;

namespace Mediator.Mediators
{
    public class ConcreteMediator
        : IMediator
    {
        private Checkbox _checkbox;
        private Input _input;

        public ConcreteMediator(Checkbox checkbox, Input input)
        {
            _checkbox = checkbox;
            _checkbox.SetMediator(this);

            _input = input;
            _input.SetMediator(this);
        }

        public void Notify(object sender, string _event)
        {
            if(sender == _checkbox)
            {
                switch (_event)
                {
                    case "check":
                        _input.Show();
                        break;

                    case "uncheck":
                        _input.Hide();
                        break;
                }
            }
            else if (sender == _input)
            {
                switch (_event)
                {
                    case "isHidden":
                        Console.WriteLine("Mediator was notified that input is hidden.");
                        break;

                    case "isNotHidden":
                        Console.WriteLine("Mediator was notified that input isn't hidden.");
                        break;
                }
            }
        }
    }
}
