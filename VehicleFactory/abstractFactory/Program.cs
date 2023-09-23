using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractFactoryLib;


namespace abstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем фабрику для спортивных транспортных средств
            VehicleFactory sportsFactory = new SportsVehicleFactory();

            // Создаем спортивный автомобиль и мотоцикл
            Car sportsCar = sportsFactory.CreateCar();
            Motorcycle sportsMotorcycle = sportsFactory.CreateMotorcycle();

            sportsCar.Drive();
            sportsMotorcycle.Ride();

            // Создаем фабрику для семейных транспортных средств
            VehicleFactory familyFactory = new FamilyVehicleFactory();

            // Создаем семейный автомобиль и мотоцикл
            Car familyCar = familyFactory.CreateCar();
            Motorcycle familyMotorcycle = familyFactory.CreateMotorcycle();

            familyCar.Drive();
            familyMotorcycle.Ride();
            Console.ReadKey();
        }
    }
}
