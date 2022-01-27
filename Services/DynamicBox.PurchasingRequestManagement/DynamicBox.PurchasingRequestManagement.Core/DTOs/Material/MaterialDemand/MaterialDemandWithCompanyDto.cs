using DynamicBox.PurchasingManagement.Core.DTOs.Company;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandWithCompanyDto: BaseDto
    {
        public string Description { get; set; } = null!;
        public string CreatedUserId { get; set; } = null!;
        public string CreatedUserName { get; set; } = null!;
        public string Status { get; set; }


        public long CompanyId { get; set; }
        public CompanyDto? Company { get; set; }
    }
}
