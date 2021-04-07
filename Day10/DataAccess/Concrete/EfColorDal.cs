using System;
using System.Collections.Generic;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color,CarRentalContext>, IColorDal
    {
    }
}
