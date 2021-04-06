using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            (Türkçe)
            Araba Kiralama projemiz icinde devam edeceğiz. Car nesnesine ek olarak;
            
            1. Marka ve Renkli eklemek ekleyiniz (Entity)
                - Marka -> Kimlik, Ad
                - Renk -> Kimlik, Ad

            2. Sql Server için yeni bir veri kurunuz. Arabalar, Markalar, Renkler tablolarını oluşturunuz. (Araştırma)
            
            3. Sistem Generic IEntityRepository altyapısı yazınız.

            4. Car, Brand ve Color eklemek için Entity Framework altyapısını yazınız.

            5. GetCarsByBrandId, GetCarsByColorId servislerini yazınız.

            6. Sistem yeni araba eklendiğinde kuralları çalıştırınız.
               - Araba ismi minimum 2 karakter olmalıdır
               - Araba fiyatı 0'dan büyük olmalıdır.
            
            
            (English)
            We will continue in our car rental project. In addition to the car object;

            1. Add Brand and Color classes. (Entity)
                - Brand -> BrandId, BrandName
                - Color -> ColorId, ColorName

            2. Add a new database for SQL Server. Create Cars, Brands, Colors tables. (Research homework)

            3. Write the System Generic IEntityRepository infrastructure.

            4. Write the Entity Framework infrastructure to add Car, Brand and Color.

            5. Write GetCarsByBrandId and GetCarsByColorId services.

            6. Run the rules when the system adds a new car:
                - The car description must be at least 2 characters.
                - The car daily price must be greater than 0.
            */


            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar1 = new Car
            {
                BrandId = 5,
                ColorId = 6,
                ModelYear = "2017",
                DailyPrice = 25,
                Description = "Superb, Compact, 4 Adults, 3 Bags"
            };
            Car newCar2 = new Car
            {
                BrandId = 2,
                ColorId = 5,
                ModelYear = "2020",
                DailyPrice = 40,
                Description = "i"
            };

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }
            carManager.AddCar(newCar1);
            carManager.AddCar(newCar2);
            carManager.DeleteCar(newCar1);
            carManager.DeleteCar(newCar2);

        }
    }
}
