import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialDemandsComponent } from './material-demands/material-demands.component';
import { MaterialDetailsComponent } from './material-details/material-details.component';
import { MaterialHistoryComponent } from './material-history/material-history.component';
import { RouterModule, Routes} from "@angular/router";
import {MatTableModule} from "@angular/material/table";
import {MatPaginatorModule} from "@angular/material/paginator";
import {MatSortModule} from "@angular/material/sort";
import {MatIconModule} from "@angular/material/icon";
import {NgxSpinnerModule} from "ngx-spinner";
import {MatMenuModule} from "@angular/material/menu";
import {MatButtonModule} from "@angular/material/button";
import { NgxPaginationModule } from "ngx-pagination";

const routes: Routes = [
  {
    path: "material-demands",
    component: MaterialDemandsComponent
  },
  {
    path: "details/:id",
    component: MaterialDetailsComponent,
    children:[
      {
        path:"material-demands-details",
        component: MaterialDemandsComponent
      },
      {
        path: "material-demands-history",
        component: MaterialHistoryComponent
      }
    ]
  },
  {
    path: "",
    //redirectTo:DocumentListComponent
    component: MaterialDemandsComponent
  }
]

@NgModule({
  declarations: [
    MaterialDemandsComponent,
    MaterialDetailsComponent,
    MaterialHistoryComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NgxPaginationModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatIconModule,
    NgxSpinnerModule,
    MatMenuModule,
    MatButtonModule
  ]
})
export class MaterialDemandModule { }
