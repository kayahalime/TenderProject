using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator: AbstractValidator<Admin>
    {
        public AdminValidator()
        {
        }
    }
}
