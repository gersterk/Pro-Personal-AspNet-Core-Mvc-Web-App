using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category must have a name");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category must have a description");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Category name can not be longer than 50 char");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Category name can not be shorter than two char");

        }
    }
}
