using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Jcon_Contact_Tracing.UserData;

namespace Jcon_Contact_Tracing.Validator
{
    public class SystemBoardValidator : AbstractValidator<SystemBoardModel>
    {
        public SystemBoardValidator()
        {
            RuleFor(item => item.Name)
                .Length(5, 15).WithMessage("System Board Name Length is invalid");
              
        }
    }
}
