using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ImageValidator: AbstractValidator<Image>
    {
        public ImageValidator()
        {
        }
    }
}
