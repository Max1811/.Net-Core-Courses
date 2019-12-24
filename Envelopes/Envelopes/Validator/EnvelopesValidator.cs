using FluentValidation;

namespace Envelopes.Validator
{
    public class EnvelopesValidator : AbstractValidator<IEnvelope>
    {

        public EnvelopesValidator()
        {
            RuleFor(envelope => envelope.Height).LessThan(envelope => double.MaxValue).GreaterThan(envelope => 0);

            RuleFor(envelope => envelope.Width).LessThan(envelope => double.MaxValue).GreaterThan(envelope => 0);
        }
    }
}

