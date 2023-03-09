using FluentValidation;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.ValidationRules.FluenValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Blank product Name");
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p=>p.QuantityPerUnit).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();
            RuleFor(p=>p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==2);
            RuleFor(p => p.UnitsInStock).GreaterThan((short)10);

            RuleFor(p => p.ProductName).Must(StartsWithA).WithMessage("Not started with A");

        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
