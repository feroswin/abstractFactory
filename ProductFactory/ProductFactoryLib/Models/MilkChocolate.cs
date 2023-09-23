using ProductFactoryLib.AbstractModels;
using System;

namespace ProductFactoryLib.Models
{
    public class MilkChocolate : Food
    {
        public override void Display()
        {
            Console.WriteLine("Молочный шоколад");
        }
    }
}
