using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTittle).NotEmpty().WithMessage("Blog Title is not empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Content is not empty");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image is not empty");
            RuleFor(x => x.BlogTittle).MaximumLength(150).WithMessage("Please enter the data less than 150 character");
            RuleFor(x => x.BlogTittle).MinimumLength(2).WithMessage("Please enter the data more than 2 character");
        }
    }
}
