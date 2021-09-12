using Business.Concrete;
using DataAccess.Abstract.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDao());
            foreach (var car in carManager.getAll())
            {
                Console.WriteLine(car.id + " " + car.description);
            }
        }
    }
}
