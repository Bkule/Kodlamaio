using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    public interface IOrderService
    {
        void AddToCart(Game game, Player player);
        void DeleteFromCart(Game game, Player player);
    }
}
