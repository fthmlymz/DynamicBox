namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail
{
    public class MaterialDemandDetailDto: BaseDto
    {
        public string StockNo { get; set; } = null!;
        public string StockName { get; set; } = null!;
        public long Total { get; set; }
        public decimal Price { get; set; }


        public long MaterialDemandId { get; set; }
    }
}
