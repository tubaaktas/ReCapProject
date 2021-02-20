using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEmpty();

            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1300).When(c => c.BrandId == 2).WithMessage("The daily price limit for BrandId = 2 is at least 1300... ");
            //açıklama kısmı V ile başlamalı, V6, V8,V4...
            RuleFor(c => c.Description).Must(StartWithV).WithMessage("Description must start with 'V'");


        }

        private bool StartWithV(string arg)
        {
            return arg.StartsWith("V");
        }
    }


}
