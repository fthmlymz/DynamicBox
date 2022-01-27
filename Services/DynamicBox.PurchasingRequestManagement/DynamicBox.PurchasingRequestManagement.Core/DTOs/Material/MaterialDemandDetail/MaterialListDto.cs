namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail
{
    public class MaterialListDto: BaseDto
    {
        public string? MaterialName { get; set; }
        public string? MaterialStockNo { get; set; }
        public string? MaterialType { get; set; }
        public string? MaterialGroup { get; set; }
    }
}
