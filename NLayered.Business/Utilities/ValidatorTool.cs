using FluentValidation;
using NLayered.Business.ValidationRules.FluenValidation;
using NLayered.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.Utilities
{
    public static class ValidatorTool<T>
    {
        public static void Validate(IValidator<T> validator,T entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
