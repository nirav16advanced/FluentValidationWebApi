using ExternalModel.Library;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationWebApi.Controllers
{
    [ApiController]

    public class DeveloperController : ControllerBase
    {
      

        [HttpPost("Fluent")]
        public async Task<IActionResult> Create(Developer developer)
        {
            return Ok();
        }

        public class DeveloperValidator : AbstractValidator<Developer>
        {
            public DeveloperValidator()
            {
                RuleFor(p => p.FirstName).NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!");
            }
        }
    }
}
