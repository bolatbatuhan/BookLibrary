using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation;

public class AuthorValidator : AbstractValidator<Author>
{
    public AuthorValidator()
    {
        RuleFor(a=>a.AuthorName).NotEmpty();
        RuleFor(a=>a.AuthorName).MinimumLength(2);
    }
}
