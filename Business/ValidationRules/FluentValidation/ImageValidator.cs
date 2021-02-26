﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ImageValidator:AbstractValidator<CarImage>
    {
        public ImageValidator()
        {
           
            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}
