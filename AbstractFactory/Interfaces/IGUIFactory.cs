using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
