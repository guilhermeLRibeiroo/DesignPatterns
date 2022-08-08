using AbstractFactory.Entities.Win;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    class WinFactory
        : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
