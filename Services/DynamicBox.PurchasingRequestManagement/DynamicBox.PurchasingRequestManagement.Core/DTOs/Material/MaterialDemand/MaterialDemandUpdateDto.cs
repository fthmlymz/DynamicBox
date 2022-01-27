namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandUpdateDto
    {
        public long Id { get; set; }
        public string Description { get; set; } = null!;

        public string Status { get; set; }


        public long CompanyId { get; set; }
    }
}
