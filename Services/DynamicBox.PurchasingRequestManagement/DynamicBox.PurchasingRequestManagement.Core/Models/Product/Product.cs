using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;

namespace DynamicBox.PurchasingRequestManagement.Core.Models.Product
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string StockNo { get; set; }


        public long CompanyId { get; set; }
        public Company Company { get; set; }


        public ICollection<MaterialDemandDetail> MaterialDemandDetails { get; set; } = new List<MaterialDemandDetail>();
    }
}
