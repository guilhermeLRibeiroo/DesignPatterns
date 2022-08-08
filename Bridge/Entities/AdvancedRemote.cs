using Bridge.Interfaces;

namespace Bridge.Entities
{
    class AdvancedRemote
        : BasicRemote
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public void Mute()
        {
            Console.WriteLine("Remote Mute");
            _device.SetVolume(0);
        }
    }
}
