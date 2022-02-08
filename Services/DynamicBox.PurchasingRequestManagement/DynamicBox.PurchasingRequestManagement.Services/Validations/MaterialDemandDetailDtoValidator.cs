using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;
using FluentValidation;

namespace DynamicBox.PurchasingRequestManagement.Services.Validations
{
    public class MaterialDemandDetailDtoValidator : AbstractValidator<MaterialDemandDetailDto>
    {
        public MaterialDemandDetailDtoValidator()
        {
            RuleFor(x => x.StockName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.TotalDemand).InclusiveBetween(1, long.MaxValue).WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.MaterialDemandId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
        }
    }
}
