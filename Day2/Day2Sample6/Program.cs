using System;

namespace Day2Sample6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            (Türkçe)
            Herhangi bir e-ticaret sistemine giriniz. Genellikle bir e - ticaret sistemine girdiğinizde ürünler listelenir. 
            Siz de Urun(Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
            Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.
            
            
            (English)
            Enter any e-commerce system. Usually when you enter an e-commerce system, products are listed.
            Create a class called Product(Product) and add a few products to an array.
            List your products separately with for, foreach and while loops.
            */


            Product product1 = new Product();
            product1.ProductName = "Roomba-i6";
            product1.ProductPrice = 559.98;
            product1.ProductDealer = "iRobot Store";

            Product product2 = new Product();
            product2.ProductName = "Humidifier";
            product2.ProductPrice = 44.15;
            product2.ProductDealer = "Upper Echelon";

            Product product3 = new Product();
            product3.ProductName = "Puzzle";
            product3.ProductPrice = 19.99;
            product3.ProductDealer = "Tzftoy";

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductPrice + " by " + products[i].ProductDealer);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + " by " + product.ProductDealer);
            }

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine(products[x].ProductName + " : " + products[x].ProductPrice + " by " + products[x].ProductDealer);
                x++;
            }
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDealer { get; set; }
    }
}
