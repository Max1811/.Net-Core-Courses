using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Sequence
{
    public class SequenceValidator: AbstractValidator<ISequence>
    {
        public SequenceValidator()
        {
            //RuleFor(sequence => sequence.From).GreaterThan(sequence => 0);

            RuleFor(sequence => sequence.To).GreaterThan(sequence => 1);

            RuleFor(sequence => sequence.To).GreaterThan(sequence => sequence.From);
        }
    }
}
