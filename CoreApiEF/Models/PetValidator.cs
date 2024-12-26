using FluentValidation;

namespace CoreApiEF.Models
{
    public class PetValidator : AbstractValidator<PetAnimal>
    {
        public PetValidator()
        {
            RuleFor(petName => petName.petName).NotEmpty().WithMessage("Pet Name is required"); 
            RuleFor(petType => petType.petType).NotEmpty().WithMessage("Pet Type is required"); 
            RuleFor(DOB => DOB.DOB).NotEmpty().WithMessage("Date of Birth must be in the format yyyy-MM-dd.").Matches(@"^\d{4}-\d{2}-\d{2}$");
        }
    }
}
