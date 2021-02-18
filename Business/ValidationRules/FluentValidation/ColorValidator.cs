using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class ColorValidator: AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c1 => c1.ColorId).NotEmpty();
            RuleFor(c1 => c1.ColorName).NotEmpty();

        }
    }
}
