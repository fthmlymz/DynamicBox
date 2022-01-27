namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialList : BaseEntity
    {
        public string? MaterialName { get; set; }
        public string? MaterialStockNo { get; set; }
        public string? MaterialType { get; set; }
        public string? MaterialGroup { get; set; }


        //public Company Company { get; set; } = null!; 
    }
}
