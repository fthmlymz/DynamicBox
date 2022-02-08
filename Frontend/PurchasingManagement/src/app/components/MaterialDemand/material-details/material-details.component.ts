import {Component, Input, OnDestroy, OnInit} from '@angular/core';
import {MaterialDemandDetail} from "../../../models/material-demand-detail/material-demand-detail";
import {MatTableDataSource} from "@angular/material/table";
import {MaterialDemandService} from "../../../services/materialdemand/material-demand.service";
import {MaterialDemandsModel} from "../../../models/material-demands/material-demands-model";
import {ActivatedRoute} from "@angular/router";
import {ajax} from "rxjs/ajax";

@Component({
  selector: 'app-material-details',
  templateUrl: './material-details.component.html',
  styleUrls: ['./material-details.component.scss']
})
export class MaterialDetailsComponent implements OnInit, OnDestroy {
  displayedColumns: string[] = [
    'id', 'stockNo', 'stockName', 'total', 'price', 'materialDemandId', 'createdDate', 'updatedDate', 'businessCode'
  ];
  materialsDetails: MaterialDemandsModel[] = []; //MaterialDemandDetail[] = [];
  dataSource = new MatTableDataSource<MaterialDemandsModel>(this.materialsDetails);
  ajax:any;

  constructor(
    private demandsService: MaterialDemandService,
    private route:ActivatedRoute
  ) { }

  getMaterialDemandsWithDetails(id: number){
    this.demandsService.getMaterialDemandsWithDetails(id).subscribe(data => {
      this.dataSource.data =  data.data;
      console.log(data.data);
    });
  }

  ngOnInit(): void {
    this.ajax = this.getMaterialDemandsWithDetails(23);

    let id = this.route.snapshot.paramMap.get("id");
    console.log(id);
  }

  //farklı sayfaya geçişlerde ajax isteğini iptal et ve server yorma
  ngOnDestroy(): void {
    if (this.ajax!=null) this.ajax.unscribe();
  }

}
