using System;

namespace abstractFactoryLib
{
    public class SportsCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Вы ведете спортивный автомобиль");
        }
    }
}
