using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            (Türkçe)
            ClassMetotDemo isimli bir proje oluşturunuz. Bunu Github'a aktarınız. Projeniz şunu yapacak.
            Bir bankada müşteri takibi yapmak istiyorsunuz. Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz.(Id, Ad, Soyad..)
            MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
               
                
            (English)
            Create a project named ClassMethodDemo. Transfer this to Github. Your project will do this.
            You want to follow up a customer in a bank. Create a Class named Customer. Add the features you want to the customer.(Id, Name, Surname....)
            Create the CustomerManager class. Simulate methods such as adding, listing, and deleting customers by taking the customer parameter.
            */


            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Berkin";
            customer1.LastName = "Kule";
            customer1.TcNo = "10000000000";
            customer1.Balance = 1000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Mehmet";
            customer2.LastName = "Öztürk";
            customer2.TcNo = "20000000000";
            customer2.Balance = 1500;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ali";
            customer3.LastName = "Yılmaz";
            customer3.TcNo = "30000000000";
            customer3.Balance = 2000;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Delete(customer2);

            customerManager.List(customers);
        }
    }
}
