using Bridge.Interfaces;

namespace Bridge.Entities
{
    class BasicRemote
        : IRemote
    {
        protected IDevice _device;

        public BasicRemote(IDevice device)
        {
            _device = device;
        }

        public void ChannelDown()
        {
            Console.WriteLine("Remote Channel Down");
            var currentChannel = _device.GetChannel();
            if(currentChannel == 1)
                _device.SetChannel(100);
            else  
                _device.SetChannel(currentChannel - 1);
        }

        public void ChannelUp()
        {
            Console.WriteLine("Remote Channel Up");
            var currentChannel = _device.GetChannel();
            if (currentChannel == 100)
                _device.SetChannel(1);
            else
                _device.SetChannel(currentChannel + 1);
        }

        public void Power()
        {
            Console.WriteLine("Remote Power Toggle");
            if(_device.IsEnabled())
                _device.Disable();
            else
                _device.Enable();
        }

        public void VolumeDown()
        {
            Console.WriteLine("Remote Volume Down");
            var currentVolume = _device.GetVolume();
            if (currentVolume != 0)
                _device.SetVolume(currentVolume - 1);
        }

        public void VolumeUp()
        {
            Console.WriteLine("Remote Volume Up");
            var currentVolume = _device.GetVolume();
            if (currentVolume != 100)
                _device.SetVolume(currentVolume + 1);
        }
    }
}
