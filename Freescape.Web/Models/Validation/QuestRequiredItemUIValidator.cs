﻿using FluentValidation;
using Freescape.Web.Models.UI.QuestEditor;

namespace Freescape.Web.Models.Validation
{
    public class QuestRequiredItemUIValidator: AbstractValidator<QuestRequiredItemUI>
    {
        public QuestRequiredItemUIValidator()
        {
            RuleFor(x => x.Resref)
                .NotNull()
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(16);

            RuleFor(x => x.Quantity)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(99);
        }
    }
}
