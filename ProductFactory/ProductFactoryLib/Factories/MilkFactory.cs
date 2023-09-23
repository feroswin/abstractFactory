using ProductFactoryLib.AbstractModels;
using ProductFactoryLib.Models;

namespace ProductFactoryLib.Factories
{
    public class MilkFactory : FoodFactory
    {
        public override Food CreateDairyProduct()
        {
            return new Milk();
        }

        public override Food CreateConfectionery()
        {
            return new MilkChocolate();
        }
    }
}
