using ProductFactoryLib.AbstractModels;
using ProductFactoryLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryLib.Factories
{
    public class CandyFactory : FoodFactory
    {
        public override Food CreateDairyProduct()
        {
            return new Yogurt();
        }

        public override Food CreateConfectionery()
        {
            return new Candy();
        }
    }
}
