using System;
using System.Collections.Generic;
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
            CarRental projenizde;
            
            1. Core katmanında Results yapılandırması yapınız.
            
            2. Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.
            
            3. Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
            
            4. Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName ****Kullanıcılar ve müşteriler ilişkilidir.
            
            5. Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi),
            ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.

            6. Projenizde bu entity'leri oluşturunuz. CRUD operasyonlarını yazınız. Yeni müşteriler ekleyiniz.

            7. Arabayı kiralama imkanını kodlayınız. Rental-->Add
            Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.


            (English)
            In Car Rental project;

            1. Configure Results classes in Core layer.

            2. Write all the Business classes that you have developed in your project, by refactoring with Results classes.
            
            3. Create Users table. Users -> Id, FirstName, LastName, Email, Password

            4.Create Customers table. Customers -> UserId, CompanyName **** Customers and Users are associated.

            5. Create Rental table that keeps the rental informations of the car. Rental -> Id, CarId, CustomerId, RentDate,
            ReturnDate. ReturnDate is null, if the car has not been delivered.

            6. Create these entities in your project. (User, Customer, Rental) Code CRUD operations. Add new customers.

            7.Code car rentals. Rental -> Add. The car must be delivered, in order to rent the car.
            */


            //CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

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
            //DeleteUsersTest(userManager);
            //UserAddTest(userManager);
            //GetAllUserTest(userManager);
            //CustomerAddTest(customerManager);
            //DeleteCustomersTest(customerManager);
            //CustomerDetailTest(customerManager);
            //GetAllRentalTest(rentalManager);
            //AddRentalTest(rentalManager);
            //RentalDetailTest(rentalManager);

        }

        private static void RentalDetailTest(RentalManager rentalManager)
        {
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental);
            }
        }

        private static void DeleteCustomersTest(CustomerManager customerManager)
        {
            foreach (var customer in customerManager.GetAll().Data)
            {
                customerManager.Delete(customer);
            }
        }

        private static void AddRentalTest(RentalManager rentalManager)
        {
            Rental rental = new Rental() { CarId = 1, CustomerId = 1, RentDate = DateTime.Now };
            rentalManager.Add(rental);
        }

        private static void CustomerDetailTest(CustomerManager customerManager)
        {
            foreach (var customer in customerManager.GetCustomerDetails().Data)
            {
                Console.WriteLine(customer);
            }
        }

        private static void CustomerAddTest(CustomerManager customerManager)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { CompanyName = "Kule AŞ"},
                new Customer() {CompanyName = "Demiroğ AŞ"},
                new Customer() {CompanyName = "Öztürk AŞ"},
                new Customer() {CompanyName = "Yılmaz AŞ"},
                new Customer() {CompanyName ="Baş AŞ"}
            };
            foreach (var customer in customers)
            {
                customerManager.Add(customer);
                Console.WriteLine(customer.CustomerId + " / " + customer.CompanyName);
            }
        }

        private static void GetAllRentalTest(RentalManager rentalManager)
        {
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.RentalId + " " + rental.RentDate);
            }
        }

        private static void DeleteUsersTest(UserManager userManager)
        {
            foreach (var user in userManager.GetAll().Data)
            {
                userManager.Delete(user);
            }
        }

        private static void UserAddTest(UserManager userManager)
        {
            List<User> users = new List<User>()
            {
                new User() {FirstName = "Berkin", LastName = "Kule", Email="qwe@qwe", Password = "qwert" },
                new User() {FirstName = "Engin", LastName = "Demiroğ", Email="asd@asd", Password = "asdfg"},
                new User() {FirstName = "Mehmet", LastName="Öztürk", Email = "zxc@zxc", Password="zxcvb"},
                new User() {FirstName = "Bulut", LastName ="Yılmaz", Email = "rty@rty", Password="rtyuı"},
                new User() {FirstName = "Ali", LastName="Baş", Email="fgh@fgh", Password = "fghjk"}
            };
            foreach (var user in users)
            {
                userManager.Add(user);
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        private static void GetAllUserTest(UserManager userManager)
        {
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
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
