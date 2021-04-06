﻿using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Concrete
{
    public class CampaignOrderManager : BaseOrderManager
    {
        private Campaign _campaign;

        public CampaignOrderManager(Campaign campaign)
        {
            _campaign = campaign;
        }

        public override void AddToCart(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " added " + game.GameName + " by $ " + game.GamePrice*(100-_campaign.Discount)/100 + 
                " to the cart.");
        }
    }
}
