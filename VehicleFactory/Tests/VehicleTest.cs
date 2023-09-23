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
        Assert.AreEqual("�� ������ ���������� ����������", result.Trim());
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
        Assert.AreEqual("�� ��������� �� ���������� ���������", result.Trim());
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
        Assert.AreEqual("�� ������ �������� ����������", result.Trim());
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
        Assert.AreEqual("�� ��������� �� �������� ���������", result.Trim());
    }

    // ��������������� ����� ��� ��������� ������ �������
    private string CaptureConsoleOutput(Action action)
    {
        // ���������� ����������� �����
        var standardOut = Console.Out;
        try
        {
            using (var consoleOutput = new StringWriter())
            {
                // �������������� ����������� ����� � StringWriter
                Console.SetOut(consoleOutput);

                // �������� ��������
                action.Invoke();

                // ���������� ����������� �����
                return consoleOutput.ToString();
            }
        }
        finally
        {
            // ��������������� ����������� �����
            Console.SetOut(standardOut);
        }
    }
}