using DynamicBox.PurchasingManagement.Core.Models.Company;

namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialDemand : BaseEntity
    {
        public string? Description { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CreatedUserName { get; set; }

        public string? Status { get; set; }



        #region Relationship
        public long CompanyId { get; set; }
        public Company Company { get; set; }




        public ICollection<MaterialDemandDetail> MaterialDemandDetails { get; set; } = new List<MaterialDemandDetail>();
        public ICollection<MaterialDemandHistory> MaterialDemandHistories { get; set; } 
        #endregion
    }
}
