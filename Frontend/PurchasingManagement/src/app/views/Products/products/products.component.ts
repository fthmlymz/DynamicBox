import {Component, OnInit} from '@angular/core';
import {ProductsModel} from "../../../models/products-model/products-model";
import {MatTableDataSource} from "@angular/material/table";
import {ProductsService} from "../../../services/products/products.service";
import {
  NgxGeneralSpinnerComponent
} from "../../shared-components/spinner/ngx-general-spinner/ngx-general-spinner.component";

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  displayedColumns: string [] = [
    'id', 'productName', 'price', 'stockNo', 'companyId', 'createdDate', 'updatedDate'
  ];
  products: ProductsModel[] = [];
  dataSource = new MatTableDataSource<ProductsModel>(this.products);


  constructor(
    public productService: ProductsService,
    public spinnerTransition: NgxGeneralSpinnerComponent
  ) { }

  onRowClicked(row: any){
    console.log('Row clicked : ', row);
  }


  getProductsAll(){
    this.productService.getProductsAll().subscribe(data => {
      this.dataSource.data =  data.data;
      this.productService.loading = false;
    });
  }

  ngOnInit( ): void {
    this.getProductsAll();
  }

}
