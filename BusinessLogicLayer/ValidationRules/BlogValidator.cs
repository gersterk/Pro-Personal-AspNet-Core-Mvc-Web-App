using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogName).NotEmpty().WithMessage("Better give a name to your blog");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("An Image would make your blog outstanding");

            RuleFor(x => x.BlogName).MaximumLength(150).WithMessage("Better to make the name shorter");
            RuleFor(x => x.BlogName).MinimumLength(3).WithMessage("Better to meke the name longer");


        }
    }
}
