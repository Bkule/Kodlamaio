using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1,BrandId=1, ColorId=1, ModelYear ="2000", DailyPrice = 13, Description="Economy"},
                new Car{CarId=2,BrandId=1, ColorId=1, ModelYear ="2013", DailyPrice = 30, Description="Standard"},
                new Car{CarId=3,BrandId=1, ColorId=2, ModelYear ="2020", DailyPrice = 54, Description="Luxury"},
                new Car{CarId=4,BrandId=2, ColorId=1, ModelYear ="2015", DailyPrice = 24, Description="Compact"},
                new Car{CarId=5,BrandId=2, ColorId=2, ModelYear ="2017", DailyPrice = 33, Description="Standard"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllById(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
