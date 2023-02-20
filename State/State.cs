namespace State
{
    public abstract class State
    {
        protected Context _context { get; set; }

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void Something();

        public abstract void SomethingElse();
    }
}
