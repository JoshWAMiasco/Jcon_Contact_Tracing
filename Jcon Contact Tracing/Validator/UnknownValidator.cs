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
                .NotEmpty().WithMessage("must fill up before submit")
                .Length(4, 20).WithMessage("Invalid input length")
                .Must(ValidInfo).WithMessage("Must contain correct identification");
                
        }

        protected bool ValidInfo(string obj)
        {
            return obj.Contains("_") //Identification for System Board Name

                    ||  // Eiter of these two Condtion Set is True. To Identify what kind of user Info.

                   obj.Substring(0, 1) == "J" //Identification for Jcon Path.

                   // The Criteria to be valid Jcon Path Name
                   && (obj.Length == 9 || obj.Length == 8)
                   && obj.Substring(4, 1) == " "
                   && obj.Substring(6, 1) == " "
                   && byte.TryParse(obj.Substring(7,obj.Length - 7), out byte result);
        }
    }
}