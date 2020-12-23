using Jcon_Contact_Tracing.UserData;
using System;
using System.IO;
using FluentValidation;

namespace Jcon_Contact_Tracing.Validator
{
    public class TextFileInfoValidator : AbstractValidator<TextFileInfoModel>
    {
        public TextFileInfoValidator()
        {
            RuleFor(t => t.title)
                .Cascade(cascadeMode: CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill up")
                .Length(4, 20).WithMessage("invalid text length")
                .Must(NotDuplicate).WithMessage("Title Already use by your Computer");
            RuleFor(d => d.dietype)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill up")
                .Length(4, 10).WithMessage("invalid text length");
            RuleFor(dn => dn.devicename)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill up")
                .Length(4, 20).WithMessage("invalid text length");
            RuleFor(a => a.author)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill up")
                .Length(4, 20).WithMessage("invalid text length");
        }

        protected bool NotDuplicate(string file)
        {
            string username = Environment.UserName;
            string CheckThisFile = @"C:\Users\UserName\Desktop\FileName.txt".Replace("UserName", username).Replace("FileName", file);

            if (File.Exists(CheckThisFile)) return false;
            else return true;
        }
    }
}