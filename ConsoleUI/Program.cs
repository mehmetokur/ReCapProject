using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());
            Console.WriteLine("................GetAll.................");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç adları :"+" "+car.Description);
            }
            Console.WriteLine("...............Car Added...............");
            Car car6 = new Car()
            {
                Id = 6,
                BrandId = 6,
                ColorId = 1,
                DailyPrice = 500,
                ModelYear = 2015,
                Description = "Toyota Corolla"
            };
            carManager.Add(car6);
            Console.WriteLine("...............New GetAll...............");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç adları :" + " " + car.Description + " " + "Araç Fiyatı :" +" "+ car.DailyPrice);
            }
            Console.WriteLine("................GetById................");
            Car car1 = carManager.GetById(1);
            Console.WriteLine(car1.Id);
            
            Console.WriteLine("................Uptaded.................");

            car6.DailyPrice = 1000;
            carManager.Update(car6);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç adları :" + " " + car.Description+" "+"Araç Fiyatı:"+" "+car.DailyPrice);
            }
            Console.WriteLine("................Deleted.................");
            carManager.Delete(car6);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç adları :" + " " + car.Description);
            }
            
           

        }
    }
}
