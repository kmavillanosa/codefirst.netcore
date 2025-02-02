﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.NetCore
{
    public class UpdateUserGroupCommandValidator : AbstractValidator<UpdateUserGroupCommand>
    {
        public UpdateUserGroupCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();

            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }
}
