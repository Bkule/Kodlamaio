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

        }

        private static void GetCarByColorIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine(car.BrandId + "/" + car.ColorId);
            }
        }

        private static void ByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.BrandId + "/" + car.ColorId);
            }
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName);
            }
        }

        private static void CrudCarTest(CarManager carManager)
        {
            Car car1 = new Car() { BrandId = 5, ColorId = 6, DailyPrice = 20, ModelYear = "2018" };
            carManager.Insert(car1);
            Console.WriteLine(car1.DailyPrice);
            car1.DailyPrice = 25;
            carManager.Update(car1);
            Console.WriteLine(car1.DailyPrice);
            carManager.Delete(car1);
        }
    }
}
