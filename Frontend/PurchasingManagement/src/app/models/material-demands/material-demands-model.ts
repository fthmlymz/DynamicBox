import {MaterialDemandDetail} from "../material-demand-detail/material-demand-detail";

export class MaterialDemandsModel {
  id: number | undefined;
  description: string | undefined;
  CreatedUserId: string | undefined;
  CreatedUserName: string | undefined;
  Status: string | undefined;
  CompanyId: string | undefined;

  details: MaterialDemandDetail[] | undefined

}
