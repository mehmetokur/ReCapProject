﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.FileHelper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ımageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }
        //[ValidationAspect(typeof(ImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimit(carImage.CarId));

            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _ımageDal.Add(carImage);
            return new SuccessResult();
        }

        
        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CarImageDelete(carImage));

            if (result != null)
            {
                return result;
            }

            _ımageDal.Delete(carImage);

            return new SuccessResult();
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_ımageDal.Get(p => p.Id == id), Messages.DesiredListed);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_ımageDal.GetAll(), Messages.CarImageGetAll);
        }

        public IDataResult<List<CarImage>> GetByImagesCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageIsEmpty(id), Messages.CarImageListed);
        }

        [ValidationAspect(typeof(ImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(_ımageDal.Get(p => p.Id == carImage.Id).ImagePath, file);
            carImage.Date = DateTime.Now;

            _ımageDal.Update(carImage);

            return new SuccessResult();
        }



        private List<CarImage> CheckIfCarImageIsEmpty(int id)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Images\default.jpg");
            var result = _ımageDal.GetAll(c => c.CarId == id).Any();

            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now } };
            }

            return _ımageDal.GetAll(p => p.CarId == id);

        }

        private IResult CarImageDelete(CarImage carImage)
        {
            try
            {
                File.Delete(carImage.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        private IResult CheckIfImageLimit(int carid)
        {
            var carImagecount = _ımageDal.GetAll(p => p.CarId == carid).Count;

            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.ImageLimit);
            }

            return new SuccessResult();
        }

        IDataResult<CarImage> IImageService.GetByImagesCarId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
