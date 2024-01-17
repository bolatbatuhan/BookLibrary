using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation;

public class PublisherValidator : AbstractValidator<Publisher>
{
    public PublisherValidator()
    {
        RuleFor(p => p.PublisherName).NotEmpty();
        RuleFor(p => p.PublisherName).MinimumLength(2);
    }
}
