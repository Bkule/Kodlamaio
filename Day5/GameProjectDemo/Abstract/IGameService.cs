using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
