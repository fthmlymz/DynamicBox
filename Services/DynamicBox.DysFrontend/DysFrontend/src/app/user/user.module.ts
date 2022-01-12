import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { UserDetailComponent } from './user-detail/user-detail.component';



@NgModule({
  declarations: [
    LoginComponent,
    UserDetailComponent
  ],
  imports: [
    CommonModule
  ]
})
export class UserModule { }
