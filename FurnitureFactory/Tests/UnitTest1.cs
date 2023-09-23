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
        Assert.AreEqual("Вы создали современный стул", result.Trim());
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
        Assert.AreEqual("Вы создали современный стол", result.Trim());
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
        Assert.AreEqual("Вы создали современный диван", result.Trim());
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
        Assert.AreEqual("Вы создали классический стул", result.Trim());
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
        Assert.AreEqual("Вы создали классический стол", result.Trim());
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
        Assert.AreEqual("Вы создали классический диван", result.Trim());
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
