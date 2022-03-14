using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using FluentValidation;

namespace DynamicBox.PurchasingRequestManagement.Services.Validations
{
    public class MaterialDemandDtoValidator : AbstractValidator<MaterialDemandDto>
    {
        public MaterialDemandDtoValidator()
        {
            RuleFor(x => x.Description).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.LdapId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.sAMAAccountName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.ObjectGuid).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.Email).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.PrefferedUserName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.LdapId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.Manager).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.Status).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.WorkflowId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.WorkflowDefinitionId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.WorkflowName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.WorkflowVersion).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.CompanyId).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
            RuleFor(x => x.CompanyName).NotNull().WithMessage("{PropertyName} bu alan gereklidir").NotEmpty().WithMessage("{PropertyName} bu alan gereklidir");
        }
    }
}
