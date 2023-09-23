using ProductFactoryLib.AbstractModels;
using System;

namespace ProductFactoryLib.Models
{
    public class Yogurt : Food
    {
        public override void Display()
        {
            Console.WriteLine("Безлактозный йогурт");
        }
    }
}
