import {Component, OnInit} from '@angular/core';
import {MaterialDemandService} from "../../../services/materialdemand/material-demand.service";
import {MaterialDemandsModel} from "../../../models/material-demands/material-demands-model";
import {NgxSpinnerService} from "ngx-spinner";
import {Router, ActivatedRoute} from "@angular/router";


@Component({
  selector: 'app-material-demands',
  templateUrl: './material-demands.component.html',
  styleUrls: ['./material-demands.component.scss']
})

export class MaterialDemandsComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'description',
    'createdUserId',
    'createdUserName',
    'status',
    'companyId',
    'actions'];

  materialDemands:  MaterialDemandsModel[] = [];
  clickedRows = new Set<MaterialDemandsModel>();

  page:number=1;
  pageSize:number=10;



  constructor(
    private demandsService:MaterialDemandService,
    private router:Router,
    private route:ActivatedRoute,
    private _spinner: NgxSpinnerService
  ) {

  }


  showSpinner(){
    this._spinner.show();
    setTimeout(() => {
      this._spinner.hide();
    }, 5000);
  }

  onRowClicked(row: any) {
    console.log('Row clicked: ', row);
  }




  ngOnInit(): void {
    //this._spinner.show();
    /*this.demandsService.getMaterialDemands(this.page, this.pageSize).subscribe(data => {
      this.materialDemands = data.data;
      this._spinner.hide();
    });*/


    this.route.paramMap.subscribe(params => {
      if(params.get("page") && params.get("pageSize")){
        this.page=Number(params.get("page"));
        this.pageSize=Number(params.get("pageSize"));
      }

      console.log(params);

      //materyalleri sıfırla
      this.materialDemands=[];

      this.demandsService.getMaterialDemands(this.page, this.pageSize).subscribe(data => {
        this.materialDemands = data.data;
        console.log(data.data);
      });
    })



  }
}
