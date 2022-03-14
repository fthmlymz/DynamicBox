import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  /*{
    path: "",
    loadChildren: () => import("./home/home/home.module").then(m => m.HomeModule)
  },*/
  {
    path: 'material-demands-list',
    loadChildren: () =>
      import('./views/MaterialDemand/material-demand.module').then(
        (m) => m.MaterialDemandModule
      ),
  },

  {
    path: 'authentication',
    loadChildren: () =>
      import('./views/auth/authentication.module').then(
        (m) => m.AuthenticationModule
      ),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
