using Observer.Observers;

namespace Observer.Subjects
{
    public class Subject
        : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public int State { get; set; } = 0;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Subject attached an observer.");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject notifying observers.");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Something()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Subject is doing some business logic..");
            State = new Random().Next(0, 10);

            Thread.Sleep(5);

            Console.WriteLine($"Subject state changed to {State}.");
            Notify();
        }
    }
}
