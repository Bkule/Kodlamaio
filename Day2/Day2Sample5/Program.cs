using System;

namespace Day2Sample5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  
            (Türkçe)
            (Bir adet quiz sorusu yazınız. Bu soru bugüne kadar öğrendiklerimizi içermelidir. Doğru cevabı belirtmeyiniz.)
                
            ----- Quiz sorusu -----
            Bir marketteki sebze-meyve reyonunda bulunan 4 adet ürünün, ürünleri ve fiyatları gösteren ve bu fiyatlar kilosu 5 Türk Lirası'ndan fazla ise 
            pahalı olduğunu, kilosu 5 Türk Lirası'ndan az ise Ucuz olduğunu gösteren bir kod yazınız. 
                
                
            (English)
            (Write a quiz question. This question should include what we have learned so far. Do not specify the correct answer.)
                
            ----- My Quiz Question -----
            Write a code that shows 4 products and their prices in fruit-vegetables section in a supermarket. Also, that code must show if the prices are more
            than 5 Turkish Liras in per kilo as "Expensive" , and less than 5 Turkish Liras in per kilo as "Cheap".
            */


            GreenGrocer banana = new GreenGrocer();
            banana.ProductName = "Banana";
            banana.ProductPrice = 9.95;
            banana.ProductType = "Fruit";

            GreenGrocer tomato = new GreenGrocer();
            tomato.ProductName = "Tomato";
            tomato.ProductPrice = 4.99;
            tomato.ProductType = "Vegetable";

            GreenGrocer leek = new GreenGrocer();
            leek.ProductName = "Leek";
            leek.ProductPrice = 6.95;
            leek.ProductType = "Vegetable";

            GreenGrocer grapefruit = new GreenGrocer();
            grapefruit.ProductName = "Grapefruit";
            grapefruit.ProductPrice = 4.99;
            grapefruit.ProductType = "Fruit";

            GreenGrocer[] greengrocer = new GreenGrocer[] { banana, tomato, leek, grapefruit };

            for (int i = 0; i < greengrocer.Length; i++)
            {
                if (greengrocer[i].ProductPrice > 5)
                {
                    Console.WriteLine(greengrocer[i].ProductName + " : " + greengrocer[i].ProductPrice + " TL/kg - Expensive " + greengrocer[i].ProductType);
                }
                else
                {
                    Console.WriteLine(greengrocer[i].ProductName + " : " + greengrocer[i].ProductPrice + " TL/kg - Cheap " + greengrocer[i].ProductType);
                }
            }
        }
    }

    class GreenGrocer
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductType { get; set; }
    }
}
