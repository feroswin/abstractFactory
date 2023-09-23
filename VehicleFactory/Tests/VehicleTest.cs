using abstractFactoryLib;

[TestFixture]
public class VehicleTests
{
    [Test]
    public void SportsCar_Drive_ShouldReturnCorrectMessage()
    {
        // Arrange
        Car sportsCar = new SportsCar();

        // Act
        string result = CaptureConsoleOutput(() => sportsCar.Drive());

        // Assert
        Assert.AreEqual("�� ������ ���������� ����������", result.Trim());
    }

    [Test]
    public void SportsMotorcycle_Ride_ShouldReturnCorrectMessage()
    {
        // Arrange
        Motorcycle sportsMotorcycle = new SportsMotorcycle();

        // Act
        string result = CaptureConsoleOutput(() => sportsMotorcycle.Ride());

        // Assert
        Assert.AreEqual("�� ��������� �� ���������� ���������", result.Trim());
    }

    [Test]
    public void FamilyCar_Drive_ShouldReturnCorrectMessage()
    {
        // Arrange
        Car familyCar = new FamilyCar();

        // Act
        string result = CaptureConsoleOutput(() => familyCar.Drive());

        // Assert
        Assert.AreEqual("�� ������ �������� ����������", result.Trim());
    }

    [Test]
    public void FamilyMotorcycle_Ride_ShouldReturnCorrectMessage()
    {
        // Arrange
        Motorcycle familyMotorcycle = new FamilyMotorcycle();

        // Act
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