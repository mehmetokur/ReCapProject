using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext rentACarContext=new RentACarContext())
            {
                var result = from rental in filter is null ? rentACarContext.Rentals : rentACarContext.Rentals.Where(filter)
                             join car in rentACarContext.Cars
                             on rental.CarId equals car.CarId
                             join customer in rentACarContext.Customers
                             on rental.CustomerId equals customer.Id
                             join user in rentACarContext.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 RentalDetailId = rental.Id,
                                 CarId = car.CarId,
                                 Description = car.Description,
                                 CustomerName = customer.CompanyName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();

            };
        }
    }
}
