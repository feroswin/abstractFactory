using ProductFactoryLib.AbstractModels;
using System;

namespace ProductFactoryLib.Models
{
    public class Candy : Food
    {
        public override void Display()
        {
            Console.WriteLine("Конфеты");
        }
    }
}
