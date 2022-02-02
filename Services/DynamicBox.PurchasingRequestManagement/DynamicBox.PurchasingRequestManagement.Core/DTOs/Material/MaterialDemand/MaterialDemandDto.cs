namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandDto: BaseDto
    {

        public List<MaterialDemandDto> MaterialDemands { get; set; }

        public string Description { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedUserName { get; set; }
        public long CompanyId { get; set; }
        public string Status { get; set; }
    }
}
