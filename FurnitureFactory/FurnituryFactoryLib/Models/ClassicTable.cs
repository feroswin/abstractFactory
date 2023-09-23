using FurnituryFactoryLib.AbstractModels;
using System;

namespace FurnituryFactoryLib.Models
{
    public class ClassicTable : Furniture
    {
        public override void Create()
        {
            Console.WriteLine("Вы создали классический стол");
        }
    }
}
