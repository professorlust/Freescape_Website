﻿using FluentValidation;
using Freescape.Web.Data.Entities;

namespace Freescape.Web.Models.Validation
{
    public class LootTableValidator: AbstractValidator<LootTable>
    {
        public LootTableValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(64);

            RuleForEach(x => x.LootTableItems)
                .SetValidator(new LootTableItemValidator());
        }

    }
}
