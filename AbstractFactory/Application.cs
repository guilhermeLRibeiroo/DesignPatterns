using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Application
    {
        private IGUIFactory _factory { get; set; }
        private IButton _button { get; set; }
        private ICheckbox _checkbox { get; set; }

        public Application(IGUIFactory factory)
        {
            _factory = factory;
            CreateUI();
        }

        public void CreateUI()
        {
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
