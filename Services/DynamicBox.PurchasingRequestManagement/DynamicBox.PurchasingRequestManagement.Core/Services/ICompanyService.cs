using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Company;

namespace DynamicBox.PurchasingRequestManagement.Core.Services
{
    public interface ICompanyService: IService<Company>
    {
        public Task<CustomResponseDto<CompanyWithMaterialDemandsDto>> GetSingleCompanyByIdWithMaterialDemandsAsync(long companyId);
    }
}
