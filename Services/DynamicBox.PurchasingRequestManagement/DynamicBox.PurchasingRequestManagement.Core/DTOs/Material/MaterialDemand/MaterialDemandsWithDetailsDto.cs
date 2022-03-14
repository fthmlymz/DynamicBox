using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandsWithDetailsDto : BaseDto
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


        public long CompanyId { get; set; }
        public string CompanyName { get; set; }



        public long MaterialDemandId { get; set; }
        public List<MaterialDemandDetailDto>? MaterialDemandDetails{ get; set; }
    }
}
