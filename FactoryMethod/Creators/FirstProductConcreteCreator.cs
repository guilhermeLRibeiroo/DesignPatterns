using FactoryMethod.Entities;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Creators
{
    class FirstProductConcreteCreator
        : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new FirstProduct();
        }
    }
}
