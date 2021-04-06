using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseOrderManager : IOrderService
    {
        public virtual void AddToCart(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " added " + game.GameName + " by $ " + game.GamePrice + " to the cart.");
        }

        public void DeleteFromCart(Game game, Player  player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " deleted " + game.GameName + " by $ " + game.GamePrice + " from the cart.");
        }
    }
}
