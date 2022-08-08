using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities
{
    class FirstProduct
        : IProduct
    {
        public string Operation()
        {
            return "First Product";
        }
    }
}
