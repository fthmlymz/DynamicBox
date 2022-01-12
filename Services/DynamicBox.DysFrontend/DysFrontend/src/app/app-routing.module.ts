import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from "./user/login/login.component";

const routes: Routes = [
  {
    path: "home",
    loadChildren: () => import("./home/home.module").then(m => m.HomeModule)
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "user/:id",
    loadChildren: () => import("./user/user.module").then(m => m.UserModule)
  },
  {
    path: "documents",
    loadChildren: () => import("./documents/documents.module").then(m => m.DocumentsModule)
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
