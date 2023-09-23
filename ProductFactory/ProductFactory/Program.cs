using ProductFactoryLib.AbstractModels;
using ProductFactoryLib.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodFactory milkFactory = new MilkFactory();
            Food milkProduct = milkFactory.CreateDairyProduct();
            Food milkConfectionery = milkFactory.CreateConfectionery();

            Console.WriteLine("Производим молочные продукты:");
            milkProduct.Display();
            milkConfectionery.Display();

            // Создаем фабрику для производства кондитерских изделий
            FoodFactory candyFactory = new CandyFactory();
            Food yogurtProduct = candyFactory.CreateDairyProduct();
            Food candyProduct = candyFactory.CreateConfectionery();

            Console.WriteLine("\nПроизводим кондитерские изделия:");
            yogurtProduct.Display();
            candyProduct.Display();

            Console.ReadKey();
        }
    }
}
