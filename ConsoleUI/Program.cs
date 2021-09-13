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
            CarManager carManager = new CarManager(new EfCarDao());
            Console.WriteLine(carManager.getCarsByColorId(1));
        }
    }
}
