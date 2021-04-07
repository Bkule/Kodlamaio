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
            1. CarRental Projenizde Core katmanı oluşturunuz.

            2. IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.

            3. Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.

            4. Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.

            5. Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)


            (English)
            1. Create a Core layer in your CarRentalProject.

            2. Create and add your IEntity, IDto, IEntityRepository, EfEntityRepositoryBase files as in the 9th day lesson.

            3. Prepare all CRUD operations for your Car, Brand, Color classes.

            4. Test all your CRUD operations for your Car, Brand, Model objects in Console. CRUD operations : GetAll, GetById, Insert, Update, Delete.

            5. List the cars with the following datas. CarName, BrandName, ColorName, DailyPrice. ( Hint : Create IDto and write join for 3 tables.)
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
            foreach (var color in colorManager.GetColorById(1))
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
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
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }
        }

        private static void GetBrandByIdTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetBrandById(1))
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
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
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }
        }

        private static void GetCarByColorIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine(car.CarName + "/" + car.BrandId + "/" + car.ColorId);
            }
        }

        private static void GetCarByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.CarName + "/" + car.BrandId + "/" + car.ColorId);
            }
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
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
