using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            (Türkçe)
            (Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary) Sadece ekleme(Add) metodunu yazınız.)
                
                
            (English)
            (Write your own Dictonary class, just like the MyList we did in the lesson. (MyDictionary) Just type in the method of add.)
            */


            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("qwe", "123");
        }
    }
}
