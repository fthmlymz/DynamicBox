using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;

namespace DynamicBox.PurchasingRequestManagement.Core.Repositeries
{
    public interface IMaterialDemandRepository: IGenericRepository<MaterialDemand>
    {
        Task<List<MaterialDemand>> GetMaterialDemandsWithCompany();
        Task<List<MaterialDemand>> GetMaterialDemandsWithDetails(long id);



        //Task<(List<MaterialDemand>, int)> GetMaterialDemandList(int page, int pageSize);
        Task<List<MaterialDemandDto>> GetMaterialDemandList(int page, int pageSize);
    }
}
