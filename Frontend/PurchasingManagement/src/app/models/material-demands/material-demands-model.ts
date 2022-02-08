import {MaterialDemandDetail} from "../material-demand-detail/material-demand-detail";

export class MaterialDemandsModel {
  id: number | undefined;
  description: string | undefined;
  createdUserId: string | undefined;
  createdUserName: string | undefined;
  status: string | undefined;
  companyId: string | undefined;
  totalCount: number | undefined;

  details: MaterialDemandDetail[] | undefined

}
