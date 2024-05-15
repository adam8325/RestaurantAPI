﻿using FluentValidation;
using Restaurants.Application.Restaurants.Dtos;

namespace Restaurants.Application.Restaurants.Validators;

public class CreateRestaurantDtoValidator : AbstractValidator<CreateRestaurantDto>
{
    private readonly List<string> validCategories = ["Arab", "Italian", "Somali"];
    public CreateRestaurantDtoValidator()
    {
        RuleFor(dto => dto.Name)
            .Length(3, 100);

        RuleFor(dto => dto.Category)
            .Must(validCategories.Contains)
            .WithMessage("Please provide a valid category");
        
        RuleFor(dto => dto.ContactEmail)
            .EmailAddress().WithMessage("Please provide a valid email address");

        RuleFor(dto => dto.PostalCode)
            .Matches(@"^\d{2}-\d{3}$").WithMessage("Please provide a valid postal code (xx-xxx)");
    }
}
