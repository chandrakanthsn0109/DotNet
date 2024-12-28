using FluentValidation;

namespace BMSApi.Models
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator() { 
            RuleFor(x => x.customerPhone).Length(10).WithMessage("Phone number must be exactly 10 characters long.").Matches(@"^\d{10}");
            RuleFor(y => y.customerName).NotEmpty().WithMessage("Customer Name is required");
            RuleFor(z => z.date).NotEmpty().WithMessage("Date of Birth must be in the format yyyy-MM-dd.").Matches(@"^\d{4}-\d{2}-\d{2}$");
            RuleFor(a => a.amount).NotEmpty().WithMessage("Enter the total amount");
            RuleFor(x => x.customerEmail).EmailAddress().WithMessage("Invalid email format.");
        }
    }
}
