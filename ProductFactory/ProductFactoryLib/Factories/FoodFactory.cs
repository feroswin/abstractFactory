using ProductFactoryLib.AbstractModels;

namespace ProductFactoryLib.Factories
{
    public abstract class FoodFactory
    {
        public abstract Food CreateDairyProduct();
        public abstract Food CreateConfectionery();
    }
}
