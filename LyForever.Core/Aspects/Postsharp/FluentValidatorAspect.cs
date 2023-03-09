using FluentValidation;
using LyForever.Core.CrossCuttingConcerns.Validation.FluentValidation;
using LyForever.Core.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Type;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.Core.Aspects.Postsharp
{
    [Serializable]
    public class FluentValidatorAspect:OnMethodBoundaryAspect
    {
        private Type _validatorType;
        public FluentValidatorAspect(Type type)
        {
            _validatorType=type;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(p=>p.GetType()==entityType);
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            foreach (IEntity entity in entities)
            {                
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
