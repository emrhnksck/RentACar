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
            RentalManager manager = new RentalManager(new EfRentalDao());

            var result = manager.getRentalDetails();


                foreach (var rental in result.data)
                {
                    Console.WriteLine(rental.CarName + " " + rental.CustomerName + " " + rental.RentDate);
                }
            }
            
            
        }
    }

