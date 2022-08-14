using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class WriterValidations :AbstractValidator<Writer>
    {
        public WriterValidations()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("You'd better don't pass here by");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("How would I mail you?");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Dude! That is not very cool!")
                .MinimumLength(8).WithMessage("Passwords are usually longer than 8 characters.")
                .MaximumLength(16).WithMessage("Passwords are usually not longer than 16 characters.")
                .Matches(@"[A-Z]+").WithMessage("At least one upper letter?")
                .Matches(@"[a-z]+").WithMessage("At least one lower letter?")
                .Matches(@"[0-9]+").WithMessage("What about spicing up your pass with some cool numbers?");
        }
    }
}
