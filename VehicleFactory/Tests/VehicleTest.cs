using abstractFactoryLib;

[TestFixture]
public class VehicleTests
{
    [Test]
    public void SportsCar_Drive_ShouldReturnCorrectMessage()
    {
        // Arrange
        SportsVehicleFactory sportVehicleFactory = new SportsVehicleFactory();

        // Act
        Car sportsCar = sportVehicleFactory.CreateCar();
        string result = CaptureConsoleOutput(() => sportsCar.Drive());

        // Assert
        Assert.AreEqual("Вы ведете спортивный автомобиль", result.Trim());
    }

    [Test]
    public void SportsMotorcycle_Ride_ShouldReturnCorrectMessage()
    {
        // Arrange
        SportsVehicleFactory sportVehicleFactory = new SportsVehicleFactory();

        // Act
        Motorcycle sportsMotorcycle = sportVehicleFactory.CreateMotorcycle();
        string result = CaptureConsoleOutput(() => sportsMotorcycle.Ride());

        // Assert
        Assert.AreEqual("Вы катаетесь на спортивном мотоцикле", result.Trim());
    }

    [Test]
    public void FamilyCar_Drive_ShouldReturnCorrectMessage()
    {
        // Arrange
        FamilyVehicleFactory familyVehicleFactory = new FamilyVehicleFactory();

        // Act
        Car familyCar = familyVehicleFactory.CreateCar();
        string result = CaptureConsoleOutput(() => familyCar.Drive());

        // Assert
        Assert.AreEqual("Вы ведете семейный автомобиль", result.Trim());
    }

    [Test]
    public void FamilyMotorcycle_Ride_ShouldReturnCorrectMessage()
    {
        // Arrange
        FamilyVehicleFactory familyVehicleFactory = new FamilyVehicleFactory();

        // Act
        Motorcycle familyMotorcycle = familyVehicleFactory.CreateMotorcycle();
        string result = CaptureConsoleOutput(() => familyMotorcycle.Ride());

        // Assert
        Assert.AreEqual("Вы катаетесь на семейном мотоцикле", result.Trim());
    }

    // Вспомогательный метод для перехвата вывода консоли
    private string CaptureConsoleOutput(Action action)
    {
        // Запоминаем стандартный вывод
        var standardOut = Console.Out;
        try
        {
            using (var consoleOutput = new StringWriter())
            {
                // Перенаправляем стандартный вывод в StringWriter
                Console.SetOut(consoleOutput);

                // Вызываем действие
                action.Invoke();

                // Возвращаем захваченный вывод
                return consoleOutput.ToString();
            }
        }
        finally
        {
            // Восстанавливаем стандартный вывод
            Console.SetOut(standardOut);
        }
    }
}