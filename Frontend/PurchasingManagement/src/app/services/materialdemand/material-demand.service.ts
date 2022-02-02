import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {MaterialDemandsModel} from "../../models/material-demands/material-demands-model";
import {environment} from "../../../environments/environment";
import {tap} from "rxjs/operators";


@Injectable({
  providedIn: 'root'
})
export class MaterialDemandService {
  private apiUrl:string = `${environment.baseUrl}/api/materialdemands`;
  public loading:boolean = true;


  constructor(
    private httpClient:HttpClient
  ) {

  }

  public getMaterialDemands (page: number, pageSize: number) {
    let api=`${this.apiUrl}/${page}/${pageSize}`;
    console.log("Burası servis : " ,{page, pageSize});
    return this.httpClient.get<{data: MaterialDemandsModel[]}>(api).pipe(tap(x =>{
      this.loading = false;

    }));
  }


  public getMaterialDemandsGetById(id:number)
  {
    let url = `${this.apiUrl}/${id}`;
    return this.httpClient.get<{data: MaterialDemandsModel}>(url);
  }


  public  deleteMaterial(id:number){
    let url = `${this.apiUrl}/${id}`;
    return this.httpClient.delete(url);
  }
}


//  public getMaterialDemands (){
//    return this.httpClient.get<MaterialDemandsModel[]>(this.apiUrl);
//  }
