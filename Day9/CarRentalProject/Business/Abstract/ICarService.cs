using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCarId(int carId);
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
        void Insert(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
