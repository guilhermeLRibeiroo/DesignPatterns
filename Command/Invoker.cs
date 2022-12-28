using Command.Commands;

namespace Command
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand onStart)
        {
            _onStart = onStart;
        }

        public void SetOnFinish(ICommand onFinish)
        {
            _onFinish = onFinish;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: On start..");
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ... doing something important");

            Console.WriteLine("Invoker: Finishing..");
            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
