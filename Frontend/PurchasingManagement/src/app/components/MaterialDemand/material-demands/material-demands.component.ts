import {Component, OnInit, ViewChild} from '@angular/core';
import {MaterialDemandService} from "../../../services/materialdemand/material-demand.service";
import {MaterialDemandsModel} from "../../../models/material-demands/material-demands-model";
import {MatPaginator, PageEvent} from "@angular/material/paginator";
import {MatTableDataSource} from "@angular/material/table";
import {MatSort} from "@angular/material/sort";
import {
  NgxGeneralSpinnerComponent
} from "../../shared-components/spinner/ngx-general-spinner/ngx-general-spinner.component";



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

  materials:MaterialDemandsModel[]=  [];
  dataSource = new MatTableDataSource<MaterialDemandsModel>(this.materials);
  @ViewChild(MatPaginator, {static: false}) paginator!:  MatPaginator;
  @ViewChild(MatSort, { static: true }) sort!: MatSort;


  page:number=1;
  pageSize:number=10;
  totalCount:number=0;
  pageSizeOptions: number[] = [5, 10, 20, 50, 100];





  constructor(
    public demandsService:MaterialDemandService,
    public spinnerTransition: NgxGeneralSpinnerComponent
  ) {

  }



  onRowClicked(row: any) {
    console.log('Row clicked: ', row);
  }

  getData(page:Number, pageSize:Number){
  this.demandsService.getMaterialDemands(Number(page), Number(pageSize)).subscribe(data => {
    this.dataSource.data =  data.data;
    this.totalCount = Number( data.data[0].totalCount);
    this.demandsService.loading = false;
  });
}

  ngOnInit(): void {
    this.getData(this.page, this.pageSize);
    this.dataSource.paginator = this.paginator;
   // this.dataSource.sort = this.sort;
  }


  onChangePage(pageEvent:PageEvent) {
    this.pageSize = pageEvent.pageSize;
    this.page = +pageEvent.pageIndex +1;
    this.getData(this.page, this.pageSize);

    this.demandsService.loading = true;
  }
}




/*pageChanged(event){
  this.page = event;
  //navigation yapmak gerekiyor ajax istekleri için
  this.router.navigateByUrl(`/material-demands/${this.page}`)
}*/
//this._spinner.show();
/*this.route.paramMap.subscribe(params => {
  if(params.get("page")){
    this.page=Number(params.get("page"));
  }

  //materyalleri sıfırla
  this.materialDemands=[];
  this.totalCount=0;

  //
  this.demandsService.getMaterialDemands(this.page, this.pageSize).subscribe(data => {
    this.materialDemands =  data.data;
  });
})*/
