using ProductFactoryLib.AbstractModels;
using System;

namespace ProductFactoryLib.Models
{
    public class Milk : Food
    {
        public override void Display()
        {
            Console.WriteLine("Молоко");
        }
    }
}
