using FurnituryFactoryLib.AbstractModels;
using System;

namespace FurnituryFactoryLib.Models
{
    public class ClassicChair : Furniture
    {
        public override void Create()
        {
            Console.WriteLine("Вы создали классический стул");
        }
    }
}
