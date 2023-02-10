namespace Memento
{
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker is saving the Originator's state");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if(_mementos.Count == 0)
                return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Caretaker is restoring Originator's state to {memento.GetName()}");

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker's list of mementos:");

            foreach(var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
