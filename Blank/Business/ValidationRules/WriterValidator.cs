using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer Name, LastName is not empty!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Writer Name must be less than 50 characters");

            RuleFor(x => x.WriterEMail).NotEmpty().WithMessage("Mail address is not empty");
            RuleFor(x => x.WriterEMail).EmailAddress().WithMessage("Invalid email address format");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password is not empty");
            //RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Password must be at least 6 characters long");
            //RuleFor(x => x.WriterPassword).Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter");
            //RuleFor(x => x.WriterPassword).Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter");
            //RuleFor(x => x.WriterPassword).Matches(@"[0-9]").WithMessage("Password must contain at least one number");
            //RuleFor(x => x.WriterPassword).Matches(@"[\W]").WithMessage("Password must contain at least one special character");

         
        }
    }

}
