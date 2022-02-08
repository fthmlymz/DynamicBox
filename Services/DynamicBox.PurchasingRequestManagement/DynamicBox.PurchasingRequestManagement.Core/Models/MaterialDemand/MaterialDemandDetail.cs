namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialDemandDetail : BaseEntity
    {
        public long TotalDemand { get; set; }
        public string StockName { get; set; }



        #region Relation Ship
        public long MaterialDemandId { get; set; }
        public MaterialDemand MaterialDemands { get; set; } = null!;

        public long ProductId { get; set; }
        public Product.Product Products { get; set; }

        #endregion
    }
}
