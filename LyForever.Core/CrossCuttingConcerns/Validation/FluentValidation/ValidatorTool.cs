using FluentValidation;
using LyForever.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidatorTool
    {
        // Cross cutting concerns are the methods for validation, security, authentication, caching, logging
        // These concerns can be called from any layer

        public static void FluentValidate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
