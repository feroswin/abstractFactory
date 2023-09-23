using System;

namespace abstractFactoryLib
{
    public class SportsMotorcycle : Motorcycle
    {
        public override void Ride()
        {
            Console.WriteLine("Вы катаетесь на спортивном мотоцикле");
        }
    }
}
