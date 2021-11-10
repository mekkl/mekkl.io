using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace mekkl.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator() 
        {
            int titleMaximumLength = 100;

            RuleFor(v => v.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(titleMaximumLength).WithMessage($"Title must not exceed {titleMaximumLength} characters.")
                .MustAsync(BeSomeValidatedLogic).WithMessage("This rule must be valid.");
        }

        private static async Task<bool> BeSomeValidatedLogic(CreatePostCommand model, string title, CancellationToken cancellationToken)
        {
            return await Task.FromResult(false);
        }
    }
}