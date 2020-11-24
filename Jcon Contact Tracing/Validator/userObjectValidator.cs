using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Jcon_Contact_Tracing.Validator
{
     public class userObjectValidator : AbstractValidator<userObject>
    {
        
        public userObjectValidator()
        {
            RuleFor(input => input.Input)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Fill up before submit")
                .Length(2, 20).WithMessage("Input Length is Not Valid")
                .Must(BeAValidInput).WithMessage("must contain identification");

            RuleFor(input => input.JconPath)
                .Length(5, 20).WithMessage("System Board Name Length invalid");
                

        }
        


        protected bool BeAValidInput(string input)
        {
            input = input.ToUpper();
            input = input.Replace("-", "");
            return input.Contains("_") || input.Substring(0, 1) == "J";
        }
    }
}
