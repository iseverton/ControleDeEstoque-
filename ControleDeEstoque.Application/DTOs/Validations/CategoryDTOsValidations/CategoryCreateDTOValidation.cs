using ControleDeEstoque.Application.DTOs.CategoryDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.DTOs.Validations.CategoryDTOsValidations;

public class CategoryCreateDTOValidation : AbstractValidator<CategoryCreateDTO>
{
    public CategoryCreateDTOValidation()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required,")
            .NotNull().WithMessage("Name is required.")
            .Length(3, 50).WithMessage("Name must be between 3 and 50 characters.");

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull().WithMessage("Description is required.")
            .Length(3, 100).WithMessage("Description must be between 3 and 100 characters.");
    }
}
