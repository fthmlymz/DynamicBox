import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MaterialDemandsModel } from '../../models/material-demands/material-demands-model';
import { environment } from '../../../environments/environment';
import { catchError, map, retry, tap } from 'rxjs/operators';
import { MaterialDemandWithDetailModel } from '../../models/material-demand-with-details-models/material-demand-with-detail-model/material-demand-with-detail-model';
import { Observable, throwError } from 'rxjs';
import { Notify } from 'notiflix/build/notiflix-notify-aio';
import { Loading } from 'notiflix/build/notiflix-loading-aio';

@Injectable({
  providedIn: 'root',
})
export class MaterialDemandService {
  private gatewayUrl: string = `${environment.gatewayUrl}`;
  public loading: boolean = true;

  constructor(private httpClient: HttpClient) {}

  httpHeaders = new HttpHeaders({
    'Content-Type': 'application/json',
    Authorization: `Bearer ${localStorage.getItem('access_token')}`,
  });

  //GATEWAY -> GET -> get material demands 1/10
  getMaterialDemands(page: number, pageSize: number) {
    return this.httpClient
      .get<{ data: MaterialDemandsModel[] }>(
        `${this.gatewayUrl}/api/services/purchasing/MaterialDemands/${page}/${pageSize}`
      )
      .pipe(
        retry(2),
        tap((x) => {
          this.loading = false;
          Loading.remove();
        }),
        catchError(this.handleError)
      );
  }

  //https://localhost:2009/api/MaterialDemands/GetMaterialDemandsWithDetails?id=23   numaralı kaydın detaylarını getir
  public getMaterialDemandsWithDetails(id: number) {
    let api = `${this.gatewayUrl}/api/services/purchasing/MaterialDemands/GetMaterialDemandsWithDetails?id=${id}`;
    return this.httpClient
      .get<{ data: MaterialDemandWithDetailModel[] }>(api)
      .pipe(
        tap((x) => {
          this.loading = false;
          Loading.remove();
        })
      );
  }

  //GATEWAY -> POST -> create material demand https://localhost:2001/api/services/purchasing/MaterialDemands
  //`${this.gatewayUrl}/api/services/purchasing/MaterialDemands/${materialId}`,
  postMaterialWithObservable(data: any): Observable<MaterialDemandsModel> {
    let api = `${this.gatewayUrl}/api/services/purchasing/MaterialDemands`;

    return this.httpClient
      .post<any>(api, JSON.stringify(data), {
        headers: this.httpHeaders,
      })
      .pipe(
        tap((x) => {
          this.loading = false;
          Loading.remove();
        }),
        retry(2),
        map(this.extractData),
        catchError(this.handleError)
      );
  }

  //PUT -> MaterialDemand
  putMaterialDemand(data: any): Observable<MaterialDemandsModel> {
    console.log(data);

    let api = `${this.gatewayUrl}/api/services/purchasing/MaterialDemands`;

    return this.httpClient
      .put<any>(api, JSON.stringify(data), { headers: this.httpHeaders })
      .pipe(
        tap((x) => {
          this.loading = false;
          Loading.remove();
        }),
        retry(2),
        map(this.extractData),
        catchError(this.handleError)
      );
  }

  public getMaterialDemandsGetById(id: number) {
    let url = `${this.gatewayUrl}/${id}`;
    return this.httpClient.get<{ data: MaterialDemandWithDetailModel }>(url);
  }

  deleteMaterialDemand(materialId: Number) {
    return this.httpClient
      .delete<any>(
        `${this.gatewayUrl}/api/services/purchasing/MaterialDemands/${materialId}`,
        { headers: this.httpHeaders }
      )
      .pipe(retry(2), catchError(this.handleError));
  }

  private extractData(res: any) {
    //console.log(res);
    return res;
  }
  private handleError(error: any) {
    let errorMessage = '';
    if (error.errorMessage instanceof ErrorEvent) {
      errorMessage = error.error.errorMessage;
    } else {
      errorMessage = `\nDurum kodu: ${error.status}}\nCevap: ${error.message}`;
    }
    //window.alert(errorMessage);
    Notify.failure(`Hata oluştu : ${errorMessage}`);
    Loading.remove();
    return throwError(() => {
      return errorMessage;
    });
  }
}

/*public getMaterialDemands (page: number, pageSize: number) {
  let api=`${this.gatewayUrl}/services/purchasing/MaterialDemands/${page}/${pageSize}`;
  return this.httpClient.get<{data: MaterialDemandsModel[]}>(api).pipe(tap(x =>{
    this.loading = false;
  }));
}


  postMaterialWithObservable(data: any): Observable<MaterialDemandsModel> {
    let api = 'https://localhost:4200/api/services/purchasing/MaterialDemands'; //`${this.gatewayUrl}/services/purchasing/MaterialDemands`;
    console.log(data);

    return this.httpClient
      .post<MaterialDemandsModel>(api, data, { headers: this.httpHeaders })
      .pipe(
        tap((x) => {
          console.log(x);
          this.loading = false;
        }),
        retry(2),
        map(this.extractData),
        catchError(this.handleError)
      );
  }



  postMaterialWithObservable(data: any): Observable<MaterialDemandsModel> {
    let api = `${this.gatewayUrl}/api/services/purchasing/MaterialDemands`;

    return this.httpClient
      .post<any>(api, JSON.stringify(data), {
        headers: this.httpHeaders,
      })
      .pipe(
        tap((x) => {
          this.loading = false;
          Loading.remove();
        }),
        retry(2),
        map(this.extractData),
        catchError(this.handleError)
      );
  }


  */
