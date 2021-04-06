using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
