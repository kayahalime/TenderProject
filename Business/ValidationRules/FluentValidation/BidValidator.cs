using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BidValidator:AbstractValidator<Bid>
    {
        public BidValidator()
        {
        }
    }
}
