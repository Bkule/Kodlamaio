using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            (Türkçe)
            Car Rental Projenizde; 
            
            1. Core katmanında Results yapılandırması yapınız.
            
            2. Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.
            
            
            (English)
            In Car Rental project;
            
            1. Configure Results classes in Core layer.

            2. Write all the Business classes that you have developed in your project, by refactoring with Results classes.
            */


            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //CarDetailsTest(carManager);
            //CrudCarTest(carManager);
            //GetCarByBrandIdTest(carManager);
            //GetCarByColorIdTest(carManager);
            //GetAllBrandTest(brandManager);
            //CrudBrandTest(brandManager);
            //GetBrandByIdTest(brandManager);
            //GetAllColorTest(colorManager);
            //CrudColorTest(colorManager);
            //GetColorByIdTest(colorManager);

        }

        private static void GetColorByIdTest(ColorManager colorManager)
        {
            var color = colorManager.GetColorById(1);
            if(color.Success)
            {
                Console.WriteLine(color.Data.ColorId + "/" + color.Data.ColorName);
            }
            else
            {
                Console.WriteLine(color.Message);
            }
        }

        private static void CrudColorTest(ColorManager colorManager)
        {
            Color color = new Color() { ColorName = "Purpl" };
            colorManager.Add(color);
            Console.WriteLine(color.ColorId + "/" + color.ColorName);
            color.ColorName = "Purple";
            colorManager.Update(color);
            Console.WriteLine(color.ColorName);
            colorManager.Delete(color);
        }

        private static void GetAllColorTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }
        }

        private static void GetBrandByIdTest(BrandManager brandManager)
        {
            var brand = brandManager.GetBrandById(1);
            if(brand.Success)
            {
                Console.WriteLine(brand.Data.BrandId + "/" + brand.Data.BrandName);
            }
            else
            {
                Console.WriteLine(brand.Message);
            }
        }

        private static void CrudBrandTest(BrandManager brandManager)
        {
            Brand brand = new Brand() { BrandName = "McLare" };
            brandManager.Add(brand);
            Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            brand.BrandName = "McLaren";
            brandManager.Update(brand);
            Console.WriteLine(brand.BrandName);
            brandManager.Delete(brand);
        }

        private static void GetAllBrandTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }
        }

        private static void GetCarByColorIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByColorId(1).Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandId + "/" + car.ColorId);
            }
        }

        private static void GetCarByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByBrandId(1).Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandId + "/" + car.ColorId);
            }
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
            }
        }

        private static void CrudCarTest(CarManager carManager)
        {
            Car car = new Car()
            {
                CarName = "A3 Sedan",
                BrandId = 1,
                ColorId = 2,
                ModelYear = "2015",
                DailyPrice = 640,
                Description = "5 Adults, 4 Bags"
            };
            carManager.Add(car);
            Console.WriteLine(car.CarId + "/" + car.CarName + "/" + car.DailyPrice);
            car.DailyPrice = 950;
            carManager.Update(car);
            Console.WriteLine(car.CarId + "/" + car.CarName + "/" + car.DailyPrice);
            carManager.Delete(car);
        }
    }
}
