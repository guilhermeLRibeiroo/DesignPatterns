using AbstractFactory.Entities.Mac;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    class MacFactory
        : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
