﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
              

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Renk Eklendi.");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk Silindi.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk Güncellendi.");
        }
    }
}
