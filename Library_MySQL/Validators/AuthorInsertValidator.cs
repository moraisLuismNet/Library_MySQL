﻿using Library.DTOs;
using FluentValidation;

namespace Library.Validators
{
    public class AuthorInsertValidator : AbstractValidator<AuthorInsertDTO>
    {
        public AuthorInsertValidator()
        {
            RuleFor(x => x.NameAuthor).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.NameAuthor).Length(2, 20).WithMessage("Name must be between 2 and 20 characters");
        }
    }
}
