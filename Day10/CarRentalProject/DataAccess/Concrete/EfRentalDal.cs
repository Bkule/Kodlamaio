using System;
using System.Collections.Generic;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;


namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<Rental> CheckCarReturn()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             where r.ReturnDate == null
                             select new Rental()
                             {
                                 CarId = r.CarId
                             };
                return result.ToList();
            }
        }

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join u in context.Users on r.CustomerId equals u.Id
                             join cu in context.Customers on r.CustomerId equals cu.UserId
                             select new RentalDetailDto()
                             {
                                 RentalId = r.Id,
                                 Name = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName,
                                 CarName = c.CarName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
