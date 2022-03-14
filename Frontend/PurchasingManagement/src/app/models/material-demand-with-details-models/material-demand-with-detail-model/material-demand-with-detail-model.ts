import {MaterialDemandDetailsModel} from "./material-demand-details-model/material-demand-details-model";

export class MaterialDemandWithDetailModel {
  id: number | undefined;
  companyId: number | undefined;
  description: string | undefined;
  createdUserId: string | undefined;
  createdUserName: string | undefined;
  status: string | undefined;
  totalCount: number | undefined;
  manager: string | undefined;

  materialDemandDetails: MaterialDemandDetailsModel[] | any; // | undefined;
}
