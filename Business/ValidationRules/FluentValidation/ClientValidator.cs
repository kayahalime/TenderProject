using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ClientValidator: AbstractValidator<Client>
    {
        public ClientValidator()
        {
        }
    }
}
