using DynamicBox.PurchasingRequestManagement.Core.DTOs.Product;
using FluentValidation;

namespace DynamicBox.PurchasingRequestManagement.Services.Validations
{
    public class ProductDtoValidator: AbstractValidator<AddProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.BusinessCode).NotNull().WithMessage("{PropertyName} bu alan gereklidir.").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.StockNo).NotNull().WithMessage("{PropertyName} bu alan gereklidir.").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.Price).NotNull().WithMessage("{PropertyName} bu alan gereklidir.").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.ProductName).NotNull().WithMessage("{PropertyName} bu alan gereklidir.").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.CompanyId).NotNull().WithMessage("{PropertyName} bu alan gereklidir.").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
        }
    }
}
