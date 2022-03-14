export class MaterialDemandsModel {
  id: number | undefined;
  description!: string | undefined;
  ldapId!: string | undefined;
  sAMAAccountName!: string | undefined;
  objectGuid!: string | undefined;
  email!: string | undefined;
  prefferedUserName!: string | undefined;
  manager!: string | undefined;

  companyName!: string | undefined;
  status!: string | undefined;
  companyId!: number | undefined;
  totalCount: number | undefined;
  workflowId!: string | undefined;
  workflowDefinitionId!: string | undefined;
  workflowName!: string | undefined;
  workflowVersion!: number | undefined;
}
