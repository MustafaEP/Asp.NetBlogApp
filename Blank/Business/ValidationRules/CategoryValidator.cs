using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name is not empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category Description is not empty");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Category Name should be min 3 character");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Category Name should be max 50 character");

        }
    }
}
