import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  /*{
    path: "",
    loadChildren: () => import("./home/home/home.module").then(m => m.HomeModule)
  },*/
  {
    path: "material-demands",
    loadChildren: () => import("./components/MaterialDemand/material-demand.module").then(m => m.MaterialDemandModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
