using DynamicBox.PurchasingManagement.Core.DTOs.Company;
using FluentValidation;

namespace DynamicBox.PurchasingRequestManagement.Services.Validations
{
    public class CompanyDtoValidator : AbstractValidator<CompanyDto>
    {
        public CompanyDtoValidator()
        {
            RuleFor(x => x.BusinessCode).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{ProductName} bu alan gereklidir"); 
        }
    }
}
