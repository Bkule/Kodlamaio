using System;
using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            (Türkçe)
            Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması 
            isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz. Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam 
            anlamadığınız durum benim için önemli değil, kendinize göre mantık geliştirebilirsiniz. Dediğim gibi kod kalitesiyle ilgileniyoruz şu an.
            Gereksinimler :
                
            1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin 
            doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle 
            yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)
                
            2. Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta 
            olmasını kastediyorum.)
                
            3. Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
                
            4. Satışlarda kampanya entegrasyonunu simule ediniz.
                
                
            (English)
            You want to write a game. We plan to develop the backend codes for this software with C#. The new members, sales, campaign managements are required.
            You can give the properties of the objects as you wish. The aim is here is the quality of the code you write. It is not important for me that you do
            not fully understand the requirements in the homework, you can develop your own logic. As I said, we are interested in code quality right now.
            Requirements :
                
            1. Simulate an environment where players can register to the system, update their information, and delete their registration. We want to verify the 
            accuracy of customer information using e-government systems. The verification is done with TcNo, Name, Surname, and Year of Birth.
           
            2. Simulate the sales environment where the game can be sold. (The sales made must be associated with the player. I mean that the player is in the 
            method as a parameter.
                
            3. Simulate the possibilities of adding, deleting and updating the new campaign to the system.

            4. Simulate the integration of the campaign in sales.
            */


            PlayerManager playerManager = new PlayerManager(new UserVerificationManager());

            Player player1 = new Player() { Id = 1, BirthYear = 1111, FirstName = "Berkin", LastName = "Kule", NationalityId = 10000000000, NickName = "KaLpie" };
            playerManager.Add(player1);

            Game game1 = new Game()
            { Id = 1, GameName = "Diablo 2 Resurrected", GamePrice = 39.99 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Halloween", Discount = 60 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            BaseOrderManager orderManager = new CampaignOrderManager(campaign1);
            orderManager.AddToCart(game1, player1);

        }
    }
}