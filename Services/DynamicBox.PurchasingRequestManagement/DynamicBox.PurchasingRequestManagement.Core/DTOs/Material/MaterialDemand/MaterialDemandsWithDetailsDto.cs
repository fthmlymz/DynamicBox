using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandsWithDetailsDto : BaseDto
    {
        public string? Description { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CreatedUserName { get; set; } 
        public string? Status { get; set; }

        public long CompanyId { get; set; }



        public long MaterialDemandId { get; set; }
        public List<MaterialDemandDetailDto>? MaterialDemandDetails{ get; set; }
    }
}
