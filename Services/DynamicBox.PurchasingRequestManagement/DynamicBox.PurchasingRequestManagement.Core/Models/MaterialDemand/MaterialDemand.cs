using DynamicBox.PurchasingManagement.Core.Models.Company;

namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialDemand : BaseEntity
    {
        public string Description { get; set; }
        public string LdapId { get; set; }
        public string sAMAAccountName { get; set; }
        public string ObjectGuid { get; set; }
        public string Email { get; set; }
        public string PrefferedUserName { get; set; }
        public string Manager { get; set; }
        public string Status { get; set; }

        #region Workflow
        public string WorkflowId { get; set; }
        public string WorkflowDefinitionId { get; set; }
        public string WorkflowName { get; set; }
        public long WorkflowVersion { get; set; }
        #endregion





        #region Relationship
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public string CompanyName { get; set; }



        public ICollection<MaterialDemandDetail> MaterialDemandDetails { get; set; } = new List<MaterialDemandDetail>();
        public ICollection<MaterialDemandHistory> MaterialDemandHistories { get; set; }
        #endregion
    }
}

//sAMAccountName, objectGUID, LDAP_ID, email, preferred_username, 
//public string? CreatedUserId { get; set; }
//public string? CreatedUserName { get; set; }