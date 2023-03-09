using FluentValidation;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.Business.Validation.FluentValidation
{
    public class ProductValidation:AbstractValidator<Product>
    {
        public ProductValidation()
        {
            // you may create custom messages for each rule
            // the fluent validation framwork support localization
            
            // Not empty rules
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("Customer Error Message");
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p=>p.UnitPice).NotEmpty();
            RuleFor(p=>p.QuantityPerUnit).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();

            RuleFor(p=>p.UnitPice).GreaterThan(0).LessThan(100);
            RuleFor(p => p.UnitPice).GreaterThan(100).When(p => p.CategoryId == 3);//conditional rules

            RuleFor(p => p.ProductName).Must(CustomerRule);
        }

        private bool CustomerRule(string arg)
        {
            return arg.StartsWith("P");
        }
    }
}
