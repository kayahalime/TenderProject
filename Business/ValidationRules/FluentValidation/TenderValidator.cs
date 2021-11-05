using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TenderValidator: AbstractValidator<Tender>
    {
        public TenderValidator()
        {
            RuleFor(t => t.Price).GreaterThan(0);
        }
    }
}
