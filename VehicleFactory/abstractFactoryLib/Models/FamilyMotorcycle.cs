using System;

namespace abstractFactoryLib
{
    public class FamilyMotorcycle : Motorcycle
    {
        public override void Ride()
        {
            Console.WriteLine("Вы катаетесь на семейном мотоцикле");
        }
    }
}
