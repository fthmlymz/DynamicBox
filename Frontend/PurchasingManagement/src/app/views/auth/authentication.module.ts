import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {RouterModule, Routes} from "@angular/router";
import {MatButtonModule} from "@angular/material/button";


const routes: Routes = [
  {
    path: "login",
    component: LoginComponent
  },

]
@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ]
})
export class AuthenticationModule { }
