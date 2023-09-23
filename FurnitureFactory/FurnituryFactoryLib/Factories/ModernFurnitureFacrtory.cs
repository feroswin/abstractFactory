using FurnituryFactoryLib.AbstractModels;
using FurnituryFactoryLib.Models;

namespace FurnituryFactoryLib.Factories
{
    public class ModernFurnitureFacrtory : FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new ModernChair();
        }

        public override Furniture CreateSofa()
        {
            return new ModernSofa();
        }

        public override Furniture CreateTable()
        {
            return new ModernTable();
        }
    }
}
