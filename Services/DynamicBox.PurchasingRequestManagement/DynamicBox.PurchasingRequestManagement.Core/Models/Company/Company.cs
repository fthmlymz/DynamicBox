using DynamicBox.PurchasingRequestManagement.Core.Models;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;

namespace DynamicBox.PurchasingManagement.Core.Models.Company
{
    public class Company: BaseEntity
    {
        public string? CompanyName { get; set; }
        public string? BusinessDescription { get; set; }



        public ICollection<MaterialDemand> MaterialDemands { get; set; } = new List<MaterialDemand>();
    }
}
