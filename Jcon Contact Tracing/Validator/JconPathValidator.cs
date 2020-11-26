using FluentValidation;
using Jcon_Contact_Tracing.UserData;

namespace Jcon_Contact_Tracing.Validator
{
    public class JconPathValidator : AbstractValidator<JconPathModel>
    {
        public JconPathValidator()
        {
            RuleFor(item => item.TableName)
            .Cascade(CascadeMode.StopOnFirstFailure)
        }
    }
}