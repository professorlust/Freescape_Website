﻿using FluentValidation;
using Freescape.Web.Models.UI.QuestEditor;

namespace Freescape.Web.Models.Validation
{
    public class QuestStateUIValidator: AbstractValidator<QuestStateUI>
    {
        public QuestStateUIValidator()
        {
            RuleFor(x => x.QuestTypeID)
                .NotNull()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.JournalStateID)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(9999);
            
            RuleForEach(x => x.KillTargets)
                .SetValidator(new QuestKillTargetUIValidator());

            RuleForEach(x => x.RequiredItems)
                .SetValidator(new QuestRequiredItemUIValidator());

            RuleForEach(x => x.RequiredKeyItems)
                .SetValidator(new QuestRequiredKeyItemUIValidator());
        }
    }
}
