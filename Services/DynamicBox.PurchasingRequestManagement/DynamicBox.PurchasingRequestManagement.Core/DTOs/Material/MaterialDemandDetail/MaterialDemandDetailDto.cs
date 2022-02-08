namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail
{
    public class MaterialDemandDetailDto: BaseDto
    {
        public string StockName { get; set; }
        public long TotalDemand { get; set; }


        public long MaterialDemandId { get; set; }
        public long ProductId { get; set; }
    }
}
