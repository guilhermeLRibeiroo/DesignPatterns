namespace Singleton.Entities
{
    class Database
    {
        private static readonly object _lock = new object();
        private static Database _instance;

        private Database() { }

        public static Database GetInstance(string value)
        {
            lock (_lock)
            {
                // Prevent threads to reach this part of code at the same time
                if (_instance == null)
                {
                    _instance = new Database();
                    _instance.Value = value;
                }
            }

            return _instance;
        }

        // This variable is meant to test if more than one thread reach the 17th line of code.
        public string Value { get; set; }
    }
}
