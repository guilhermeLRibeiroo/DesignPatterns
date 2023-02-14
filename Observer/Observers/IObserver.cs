using Observer.Subjects;

namespace Observer.Observers
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
