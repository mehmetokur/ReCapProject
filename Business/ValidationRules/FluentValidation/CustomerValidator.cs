using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c2 => c2.Id).NotEmpty();
            RuleFor(c2 => c2.UserId).NotEmpty();
            RuleFor(c2 => c2.CompanyName).NotEmpty();
        }
    }
}
