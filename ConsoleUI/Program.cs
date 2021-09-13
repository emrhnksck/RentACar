using Business.Concrete;
using DataAccess.Abstract.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new EfCarDao());

            foreach (var car in manager.GetCarDetails())
            {
                Console.WriteLine(car.carName + "  " + car.brandName + " " + car.colorName);
            }
        }
    }
}
