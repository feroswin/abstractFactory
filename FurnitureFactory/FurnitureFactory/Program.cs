using FurnituryFactoryLib.AbstractModels;
using FurnituryFactoryLib.Factories;
using System;

namespace FurnitureFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModernFurnitureFacrtory modernFactory = new ModernFurnitureFacrtory();

            // Создаем современную мебель
            Furniture modernChair = modernFactory.CreateChair();
            Furniture modernTable = modernFactory.CreateTable();
            Furniture modernSofa = modernFactory.CreateSofa();

            // Создаем мебель с помощью метода Create
            modernChair.Create();
            modernTable.Create();
            modernSofa.Create();

            // Создаем фабрику для классической мебели
            ClassicFurnitureFactory classicFactory = new ClassicFurnitureFactory();

            // Создаем классическую мебель
            Furniture classicChair = classicFactory.CreateChair();
            Furniture classicTable = classicFactory.CreateTable();
            Furniture classicSofa = classicFactory.CreateSofa();

            // Создаем мебель с помощью метода Create
            classicChair.Create();
            classicTable.Create();
            classicSofa.Create();
            Console.ReadKey();
        }
    }
}
