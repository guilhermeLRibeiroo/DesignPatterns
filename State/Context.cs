namespace State
{
    public class Context
    {
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context is transitioning to {state.GetType().Name}");
            _state = state;
            _state.SetContext(this);
        }

        public void Something()
        {
            _state.Something();
        }

        public void SomethingElse()
        {
            _state.SomethingElse();
        }
    }
}
