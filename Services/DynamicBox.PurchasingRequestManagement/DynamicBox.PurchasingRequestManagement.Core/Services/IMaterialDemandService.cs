using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;

namespace DynamicBox.PurchasingRequestManagement.Core.Services
{
    public interface IMaterialDemandService: IService<MaterialDemand>
    {
        Task<CustomResponseDto<List<MaterialDemandWithCompanyDto>>> GetMaterialDemandsWithCompany();
        Task<CustomResponseDto<List<MaterialDemandsWithDetailsDto>>> MaterialDemandsWithDetails(long id);
        Task<CustomResponseDto<List<MaterialDemandDto>>> GetMaterialDemandList(int page, int pageSize);
    }
}
