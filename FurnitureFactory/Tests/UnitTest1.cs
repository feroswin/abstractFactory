using FurnituryFactoryLib.AbstractModels;
using FurnituryFactoryLib.Factories;
using NUnit.Framework;

[TestFixture]
public class FurnitureTests
{
    [Test]
    public void ModernChairCreateTest()
    {
        // Arrange
        ModernFurnitureFacrtory modernFactory = new ModernFurnitureFacrtory();

        // Act
        Furniture modernChair = modernFactory.CreateChair();
        string result = CaptureConsoleOutput(() => modernChair.Create());

        // Assert
        Assert.AreEqual("�� ������� ����������� ����", result.Trim());
    }

    [Test]
    public void ModernTableCreateTest()
    {
        // Arrange
        ModernFurnitureFacrtory modernFactory = new ModernFurnitureFacrtory();

        // Act
        Furniture modernTable = modernFactory.CreateTable();
        string result = CaptureConsoleOutput(() => modernTable.Create());

        // Assert
        Assert.AreEqual("�� ������� ����������� ����", result.Trim());
    }

    [Test]
    public void ModernSofaCreateTest()
    {
        // Arrange
        ModernFurnitureFacrtory modernFactory = new ModernFurnitureFacrtory();

        // Act
        Furniture modernSofa = modernFactory.CreateSofa();
        string result = CaptureConsoleOutput(() => modernSofa.Create());

        // Assert
        Assert.AreEqual("�� ������� ����������� �����", result.Trim());
    }

    [Test]
    public void ClassicChairCreateTest()
    {
        // Arrange
        ClassicFurnitureFactory classicFactory = new ClassicFurnitureFactory();

        // Act
        Furniture classicChair = classicFactory.CreateChair();
        string result = CaptureConsoleOutput(() => classicChair.Create());

        // Assert
        Assert.AreEqual("�� ������� ������������ ����", result.Trim());
    }

    [Test]
    public void ClassicTableCreateTest()
    {
        // Arrange
        ClassicFurnitureFactory classicFactory = new ClassicFurnitureFactory();

        // Act
        Furniture classicTable = classicFactory.CreateTable();
        string result = CaptureConsoleOutput(() => classicTable.Create());

        // Assert
        Assert.AreEqual("�� ������� ������������ ����", result.Trim());
    }

    [Test]
    public void ClassicSofaCreateTest()
    {
        // Arrange
        ClassicFurnitureFactory classicFactory = new ClassicFurnitureFactory();

        // Act
        Furniture classicSofa = classicFactory.CreateSofa();
        string result = CaptureConsoleOutput(() => classicSofa.Create());

        // Assert
        Assert.AreEqual("�� ������� ������������ �����", result.Trim());
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
