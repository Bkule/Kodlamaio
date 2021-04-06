using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    public interface IUserVerificationService
    {
        bool Validate(Player player);
    }
}
