using FluentValidation;

namespace Newsletter.Api.Features.Articales.CreateArticale
{
    public class CreateArticaleValidator:AbstractValidator<CreateArticaleRequest>
    {
        public CreateArticaleValidator() { 
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
