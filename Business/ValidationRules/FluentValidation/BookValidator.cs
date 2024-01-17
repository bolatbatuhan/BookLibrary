using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(b=>b.BookName).NotEmpty();
        RuleFor(b => b.BookName).MinimumLength(2);
        RuleFor(b => b.Price).GreaterThan(0);
        RuleFor(b=>b.Description).NotEmpty();
    }
}
