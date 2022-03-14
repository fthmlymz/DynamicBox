namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MaterialDemandDto: BaseDto
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
    }
}



//        public string CreatedUserId { get; set; }
//public string CreatedUserName { get; set; }
/*
   id: number | undefined;
  description!: string | undefined;
  ldapId!: string | undefined;
  sAMAAccountName!: string | undefined;
  objectGuid!: string | undefined;
  email!: string | undefined;
  preffredUserName!: string | undefined;
  manager!: string | undefined;

  companyName!: string | undefined;
  status!: string | undefined;
  companyId!: number | undefined;
  totalCount: number | undefined;
  workflowId!: string | undefined;
  workflowDefinitionId!: string | undefined;
  workflowName!: string | undefined;
  workflowVersion!: number | undefined
*/