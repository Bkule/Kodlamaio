﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CompanyName).NotEmpty();
            RuleFor(p => p.CompanyName).Length(2,250);

        }
    }
}
