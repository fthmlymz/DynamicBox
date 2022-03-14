import {Component, OnDestroy, OnInit} from '@angular/core';
import {MatTableDataSource} from "@angular/material/table";
import {MaterialDemandService} from "../../../services/materialdemand/material-demand.service";
import {ActivatedRoute} from "@angular/router";
import {
  MaterialDemandWithDetailModel
} from "../../../models/material-demand-with-details-models/material-demand-with-detail-model/material-demand-with-detail-model";

@Component({
  selector: 'app-material-details',
  templateUrl: './material-details.component.html',
  styleUrls: ['./material-details.component.scss']
})
export class MaterialDetailsComponent implements OnInit, OnDestroy {
  displayedColumns: string[] = [
   'id', 'stockName' //'materialDemandId', 'productId',  'totalDemand', 'createdDate', 'updatedDate', 'materialDemandDetails'
  ];
  materialsDetails: MaterialDemandWithDetailModel[] = [];
  dataSource = new MatTableDataSource<MaterialDemandWithDetailModel>(this.materialsDetails);
  ajax:any;

  constructor(
    private demandsService: MaterialDemandService,
    private route:ActivatedRoute
  ) { }

  getMaterialDemandsWithDetails(id: number){
    this.demandsService.getMaterialDemandsWithDetails(id).subscribe(data => {
      this.materialsDetails =  data.data;
      console.log("materials",this.materialsDetails);
    });
  }

  ngOnInit(): void {
    let id = this.route.snapshot.paramMap.get("id");
    this.ajax = this.getMaterialDemandsWithDetails(Number(id));
    //console.log(id);
  }

  //farklı sayfaya geçişlerde ajax isteğini iptal et ve server yorma
  ngOnDestroy(): void {
    if (this.ajax!=null) this.ajax.unscribe();
  }

}
