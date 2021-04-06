using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;

namespace GameProjectDemo.Entity
{
    public class Game : GameManager
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
