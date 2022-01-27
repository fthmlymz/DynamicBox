using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using FluentValidation;

namespace DynamicBox.PurchasingRequestManagement.Services.Validations
{
    public class MaterialDemandDtoValidator : AbstractValidator<MaterialDemandDto>
    {
        public MaterialDemandDtoValidator()
        {
            RuleFor(x => x.CreatedUserId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.CreatedUserName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.CompanyId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.BusinessCode).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            
        }
    }
}
