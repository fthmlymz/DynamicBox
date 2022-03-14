using DynamicBox.PurchasingManagement.Core.DTOs.Company;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandWithCompanyDto: BaseDto
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


        public string CompanyName { get; set; }
        public long CompanyId { get; set; }
        public CompanyDto? Company { get; set; }
    }
}
