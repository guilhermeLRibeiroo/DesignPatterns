namespace Memento
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine($"Originator state is: {_state}");
        }

        public void ChangeState()
        {
            Console.WriteLine("Originator is doing something..");
            _state = GenerateRandomString(30);
            Console.WriteLine($"Originator new state is: {_state}");
        }

        private string GenerateRandomString(int length)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while(length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            if(!(memento is ConcreteMemento))
            {
                throw new Exception($"Unknown memento class {memento}");
            }

            this._state = memento.GetState();
            Console.WriteLine($"Originator state was restored to: {_state}");
        }
    }
}
