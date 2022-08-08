using FactoryMethod.Entities;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Creators
{
    class SecondProductConcreteCreator
        : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new SecondProduct();
        }
    }
}
