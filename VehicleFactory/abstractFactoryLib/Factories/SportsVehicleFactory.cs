namespace abstractFactoryLib
{
    public class SportsVehicleFactory: VehicleFactory
    {
        public override Car CreateCar()
        {
            return new SportsCar();
        }

        public override Motorcycle CreateMotorcycle()
        {
            return new SportsMotorcycle();
        }
    }
}
