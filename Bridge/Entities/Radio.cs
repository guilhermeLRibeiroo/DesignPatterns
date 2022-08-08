using Bridge.Interfaces;

namespace Bridge.Entities
{
    class Radio
        : IDevice
    {
        private bool _on { get; set; }
        private int _volume { get; set; }
        private int _channel { get; set; }

        public Radio()
        {
            _on = false;
            _volume = 30;
            _channel = 3;
        }

        public void Disable()
        {
            _on = false;
        }

        public void Enable()
        {
            _on = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public bool IsEnabled()
        {
            return _on;
        }

        public void LogStatus()
        {
            Console.WriteLine("Radio Status: ");
            Console.WriteLine(_on ? "Is on." : "Is off.");
            Console.WriteLine("Current Volume is {0}", _volume);
            Console.WriteLine("Current Channel is {0}", _channel);
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }
}
