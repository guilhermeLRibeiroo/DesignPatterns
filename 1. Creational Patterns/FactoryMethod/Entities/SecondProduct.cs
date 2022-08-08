using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities
{
    class SecondProduct
        : IProduct
    {
        public string Operation()
        {
            return "Second Product";
        }
    }
}
