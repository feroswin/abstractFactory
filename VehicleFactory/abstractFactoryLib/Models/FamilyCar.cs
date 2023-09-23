using System;

namespace abstractFactoryLib
{
    public class FamilyCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Вы ведете семейный автомобиль");
        }
    }
}

