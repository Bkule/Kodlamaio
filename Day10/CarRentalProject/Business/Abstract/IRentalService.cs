using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByDate(DateTime datetime);
        IDataResult<List<Rental>> GetRentalsByUserId(int id);
        IDataResult<List<Rental>> GetRentalsByCarId(int id);
        IDataResult<Rental> GetByRentalId(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        
    }
}
