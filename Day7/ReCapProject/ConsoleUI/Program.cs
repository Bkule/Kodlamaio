using System;
using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            (Türkçe)
            Araba kiralama sistemi yazıyoruz.
            Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)
            Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.
            Bir araba nesnesi oluşturunuz. "Car"
            Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz.
            InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
            Consolda test ediniz.
                
                
            (English)
            We will write Car Rental System.
            Create a new project called ReCapProject
            Create Entities, DataAccess, Business and Console layers.
            Create a car object. Add features : Id, BrandId, ColorId, ModelYear, DailyPrice, Description.
            Write the operations : GetById, GetAll, Add, Update, Delete in InMemory format.
            */


            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}
