using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static object BrandManager { get; private set; }

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            //foreach (var car in carManager.GetCarDetailDtos().Data)
            //{
            //    Console.WriteLine(car.CarId+" "+car.Description+" "+car.ColorName+" "+car.BrandName+" "+car.DailyPrice);
            //}

            





            //GFiyatTest(carManager);

            //IsimTest(brandManager);

            //AracListTest(carManager);

            //MarkaListTest(brandManager);

            //RenkListTest(colorManager);

            //AracEkleSilGuncelleTest(carManager);

            //MarkaEkleSilGüncelleTest(brandManager);

            //RenkEkleSilGuncelleTest(colorManager);

            

        }

        private static void RenkEkleSilGuncelleTest(ColorManager colorManager)
        {
            Console.WriteLine("***Renk ekleme, güncelleme ve silme testi***");
            Color color1 = new Color { ColorId = 5, ColorName = "Gri" };
            colorManager.Add(color1);
            colorManager.Update(color1);
            colorManager.Delete(color1);
        }

        private static void MarkaEkleSilGüncelleTest(BrandManager brandManager)
        {
            Console.WriteLine("***Marka ekleme, güncelleme ve silme testi***");
            Brand brand2 = new Brand { BrandId = 7, BrandName = "Kia" };
            brandManager.Add(brand2);
            brandManager.Update(brand2);
            brandManager.Delete(brand2);
        }

        private static void AracEkleSilGuncelleTest(CarManager carManager)
        {
            Console.WriteLine("***Araç ekleme, güncelleme ve silme testi***");
            Car car2 = new Car { CarId = 9, BrandId = 5, ColorId = 4, DailyPrice = 150, Description = "City", ModelYear = "2014" };
            carManager.Add(car2);
            carManager.Update(car2);
            carManager.Delete(car2);
        }

        private static void RenkListTest(ColorManager colorManager)
        {
            Console.WriteLine("********Renk Listesi*********");
            foreach (var Color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Renk ID : " + Color.ColorId + "Renk Adı : " + Color.ColorName);
            }
        }

        private static void MarkaListTest(BrandManager brandManager)
        {
            Console.WriteLine("********Marka Listesi*********");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Marka ID : " + brand.BrandId + " Marka Adı : " + brand.BrandName);
            }
        }

        private static void AracListTest(CarManager carManager)
        {
            Console.WriteLine("*********Tüm Araç Listesi***********");
            foreach (var Car in carManager.GetAll().Data)
            {
                Console.WriteLine("Araç ID : " + Car.CarId + " Araç Adı : " + Car.Description + " Marka ID : " + Car.BrandId + " Renk ID : " + Car.ColorId
                 + " Araç Modeli : " + Car.ModelYear + " Günlük Fiyatı : " + Car.DailyPrice);
            }
        }

        private static void IsimTest(BrandManager brandManager)
        {
            Console.WriteLine("***********İsim Testi***********");
            Brand brand1 = new Brand { BrandId = 6, BrandName = "A" };
            brandManager.Add(brand1);
        }

        private static void GFiyatTest(CarManager carManager)
        {
            Console.WriteLine("***********Günlük Fiyat Testi********");
            Car car1 = new Car { CarId = 8, BrandId = 5, ColorId = 4, DailyPrice = 0, Description = "Civic", ModelYear = "2014" };
            carManager.Add(car1);
        }
    }
}
