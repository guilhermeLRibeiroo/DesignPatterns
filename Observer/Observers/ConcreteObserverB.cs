using Observer.Subjects;

namespace Observer.Observers
{
    public class ConcreteObserverB
        : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State >= 5)
            {
                Console.WriteLine("ConcreteObserverB is reacting to the event.");
            }
        }
    }
}
