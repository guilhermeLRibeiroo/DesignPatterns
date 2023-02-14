using Observer.Subjects;

namespace Observer.Observers
{
    public class ConcreteObserverA
        : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State <= 5)
            {
                Console.WriteLine("ConcreteObserverA is reacting to the event.");
            }
        }
    }
}
