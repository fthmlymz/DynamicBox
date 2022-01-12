import {NgModule, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule, Routes} from "@angular/router";


import { DocumentListComponent } from './document-list/document-list.component';
import { DocumentInstancesComponent } from './document-instances/document-instances.component';
import { DocumentDetailsComponent } from './document-details/document-details.component';

//import {ToastrModule, } from 'ngx-toastr';

const routes: Routes = [
  {
    path: "",
    component: DocumentListComponent
  },
  {
    path: ":id",
    component: DocumentDetailsComponent,
    children:[
      {
        path:"document-instances",
        component: DocumentInstancesComponent
      }
    ]
  },
  {
    path: "",
    //redirectTo:DocumentListComponent
    component: DocumentListComponent
  }
]

@NgModule({
  declarations: [
    DocumentListComponent,
    DocumentInstancesComponent,
    DocumentDetailsComponent
  ],
  imports: [
    CommonModule,

    //toastr için
    //BrowserAnimationsModule,
    //ToastrModule,
    RouterModule.forChild(routes)
  ],
  bootstrap:[DocumentListComponent]

})

export class DocumentsModule {
  title = 'dokumen module';





}
