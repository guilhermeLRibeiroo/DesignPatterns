namespace Command.Commands
{
    public class SimpleCommand
        : ICommand
    {
        private string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Can do things like printing {this._payload}.");
        }
    }
}
