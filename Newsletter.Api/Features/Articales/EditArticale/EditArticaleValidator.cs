using FluentValidation;

namespace Newsletter.Api.Features.Articales.EditArticale
{
    public class EditArticaleValidator:AbstractValidator<EditArticaleRequest>
    {
        public EditArticaleValidator() { 
            RuleFor(x=>x.Title)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(3);


            RuleFor(x => x.Content)
              .NotNull()
              .NotEmpty()
              .MinimumLength(3);
        }
    }
}
