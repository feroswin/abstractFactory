using FurnituryFactoryLib.AbstractModels;
using System;

namespace FurnituryFactoryLib.Models
{
    public class ModernChair : Furniture
    {
        public override void Create()
        {
            Console.WriteLine("Вы создали современный стул");
        }
    }
}
