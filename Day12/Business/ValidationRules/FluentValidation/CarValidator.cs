using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).Length(2,50);
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.ModelYear).Length(4);
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.Description).MaximumLength(250);
        }
    }
}
