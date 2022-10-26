﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TaskBoardManagementApp.Application.Issues.Constants;

namespace TaskBoardManagementApp.Application.Issues.Commands.CreateIssue;

public class CreateIssueCommandValidator : AbstractValidator<CreateIssueCommand>
{
    public CreateIssueCommandValidator()
    {
        RuleFor(x => x.Title)
            .MinimumLength(12)
            .NotEmpty()
            .WithMessage($"{IssueMessages.MinTitleLengthMessage} or {IssueMessages.TitleCannotBeEmpty}");
    }
}
