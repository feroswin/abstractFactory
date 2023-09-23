using FurnituryFactoryLib.AbstractModels;
using System;

namespace FurnituryFactoryLib.Models
{
    public class ModernSofa : Furniture
    {
        public override void Create()
        {
            Console.WriteLine("Вы создали современный диван");
        }
    }
}
