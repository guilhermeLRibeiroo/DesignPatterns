namespace Command
{
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Is working on ({a}).");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Is doing other things, like ({b}).");
        }
    }
}
