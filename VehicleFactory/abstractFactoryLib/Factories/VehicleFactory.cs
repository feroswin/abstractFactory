namespace abstractFactoryLib
{
    public abstract class VehicleFactory
    {
        public abstract Car CreateCar();
        public abstract Motorcycle CreateMotorcycle();
    }
}
