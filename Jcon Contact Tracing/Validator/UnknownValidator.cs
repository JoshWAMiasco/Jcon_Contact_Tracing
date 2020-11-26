using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Jcon_Contact_Tracing.UserData;

namespace Jcon_Contact_Tracing.Validator
{
    public class UnknownValidator : AbstractValidator<UnknownModel>
    {
        public UnknownValidator()
        {
            RuleFor(item => item.obj)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Must fillup before submit")
                .Length(4, 20).WithMessage("Invalid input length")
                .Must(ValidInfo).WithMessage("Must contain identification");
                
        }

        protected bool ValidInfo(string obj)
        {
            return obj.Contains("_") || obj.Substring(0, 1) == "J";
        }
    }
}
