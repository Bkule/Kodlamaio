using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is added by $ " + game.GamePrice + " to the system.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is deleted from the system.");
        }
    }
}
