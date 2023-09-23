using FurnituryFactoryLib.AbstractModels;
using FurnituryFactoryLib.Models;

namespace FurnituryFactoryLib.Factories
{
    public class ClassicFurnitureFactory : FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new ClassicChair();
        }

        public override Furniture CreateSofa()
        {
            return new ClassicSofa();
        }

        public override Furniture CreateTable()
        {
            return new ClassicTable();
        }
    }
}
