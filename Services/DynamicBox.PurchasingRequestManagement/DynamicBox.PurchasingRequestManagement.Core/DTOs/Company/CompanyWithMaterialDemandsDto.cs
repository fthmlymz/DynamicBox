using DynamicBox.PurchasingManagement.Core.DTOs.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Company
{
    public class CompanyWithMaterialDemandsDto: CompanyDto
    {
        public List<MaterialDemandDto>? MaterialDemands { get; set; }
    }
}
