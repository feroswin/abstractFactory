using FurnituryFactoryLib.AbstractModels;

namespace FurnituryFactoryLib.Factories
{
    public abstract class FurnitureFactory
    {
        public abstract Furniture CreateChair();
        public abstract Furniture CreateTable();
        public abstract Furniture CreateSofa();
    }
}
