import {CUSTOM_ELEMENTS_SCHEMA, NgModule} from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgxGeneralSpinnerComponent } from './spinner/ngx-general-spinner/ngx-general-spinner.component';
import {NgxSpinnerModule} from "ngx-spinner";



@NgModule({
  declarations: [
    NgxGeneralSpinnerComponent
  ],
  exports: [
    NgxGeneralSpinnerComponent
  ],
  imports: [
    CommonModule,
    NgxSpinnerModule
  ],
  //schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class SharedModuleModule { }
