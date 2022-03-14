import { Injectable } from '@angular/core';
import {environment} from "../../../environments/environment";
import {HttpClient} from "@angular/common/http";
import {ProductsModel} from "../../models/products-model/products-model";
import {tap} from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  private gatewayUrl: string = `${environment.gatewayUrl}/api`;
  public loading: boolean = true;

  constructor(
    private httpClient: HttpClient
  ) { }


  public  getProductsAll(){
    let api = `${this.gatewayUrl}/products`;
    return this.httpClient.get<{data: ProductsModel[]}>(api).pipe(tap(x => {
      this.loading = false;
    }));
  }

  public getProductById(id: number){
    let api = `${this.gatewayUrl}/products/${id}`;
    return this.httpClient.get<{data: ProductsModel[]}>(api).pipe(tap(x => {
      this.loading = false;
    }));
  }


}
