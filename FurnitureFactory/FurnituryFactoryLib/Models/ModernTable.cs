using FurnituryFactoryLib.AbstractModels;
using System;

namespace FurnituryFactoryLib.Models
{
    public class ModernTable : Furniture
    {
        public override void Create()
        {
            Console.WriteLine("Вы создали современный стол");
        }
    }
}
