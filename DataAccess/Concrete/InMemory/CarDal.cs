using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
   public class CarDal : ICarDal
    {
        List<Car> _cars;

        public CarDal()
        {
            _cars = new List<Car>
            {
                new Car(){Id=1,BrandId=1,ColorId=2,ModelYear=2017,DailyPrice=350,Description="Ford Connect 2017"},
                new Car(){Id=2,BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=150,Description="BMW x5 2005"},
                new Car(){Id=3,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=650,Description="Fiat Egea Sedan"},
                new Car(){Id=4,BrandId=4,ColorId=2,ModelYear=2013,DailyPrice=250,Description="Ford focus"},
                new Car(){Id=5,BrandId=5,ColorId=2,ModelYear=2009,DailyPrice=180,Description="wolkswagen Gold"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Car Added.");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, string>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId; ;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
            carToUptade.ModelYear = car.ModelYear;
        }
    }
}
