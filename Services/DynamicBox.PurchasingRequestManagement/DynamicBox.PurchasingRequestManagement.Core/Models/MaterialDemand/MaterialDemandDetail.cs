namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialDemandDetail : BaseEntity
    {
        public string StockNo { get; set; } = null!;
        public string StockName { get; set; } = null!;
        public long Total { get; set; }
        public decimal Price { get; set; }




        public long MaterialDemandId { get; set; }
        public MaterialDemand MaterialDemands { get; set; } = null!;
    }
}
