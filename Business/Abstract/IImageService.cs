using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetByImagesCarId(int id);
        IDataResult<CarImage> Get(int id);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
       
    }
}
