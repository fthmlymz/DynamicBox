import { Injectable } from '@angular/core';
import {environment} from "../../../environments/environment";
import {HttpClient} from "@angular/common/http";
import {WorkflowListModel} from "../../models/workflow-list-model/workflow-list-model";
import {tap} from "rxjs/operators";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class WorkflowListService {
  private gatewayUrl: string = `${environment.gatewayUrl}/api`;
  public loading: boolean = true;


  constructor(private httpClient:HttpClient) { }


  //GATEWAY : https://localhost:2001/services/autoflow/workflow-list
  public getWorkflowDefinitions(){
    let api = `${this.gatewayUrl}/services/AutoFlow/workflow-list`;
    return this.httpClient.get<{items: WorkflowListModel[]}>(api).pipe(tap(x =>{
      this.loading = false;
    }));
  }


  //public getWorkflowDefinitions(): Observable<WorkflowListModel[]> {
  //  return this.httpClient.get<WorkflowListModel[]>(`${this.apiUrl}/services/workflows`);
  //}
}
