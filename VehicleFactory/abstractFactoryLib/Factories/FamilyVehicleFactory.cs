namespace abstractFactoryLib
{
    public class FamilyVehicleFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new FamilyCar();
        }

        public override Motorcycle CreateMotorcycle()
        {
            return new FamilyMotorcycle();
        }
    }
}
