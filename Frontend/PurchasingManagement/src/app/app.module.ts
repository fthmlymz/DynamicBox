import {CUSTOM_ELEMENTS_SCHEMA, NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MatSidenavModule} from "@angular/material/sidenav";
import {MatListModule} from "@angular/material/list";
import {MatIconModule} from "@angular/material/icon";
import {MatMenuModule} from "@angular/material/menu";
import {MatToolbarModule} from "@angular/material/toolbar";
import { SideNavListComponent } from './layout/side-nav-list/side-nav-list.component';
import { HttpClientModule } from '@angular/common/http';
import {MatButtonModule} from "@angular/material/button";
import { MenuListComponent } from './layout/menu-list/menu-list.component';




@NgModule({
  declarations: [
    AppComponent,
    SideNavListComponent,
    MenuListComponent
  ],
    imports: [
      BrowserModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      MatSidenavModule,

      MatListModule,
      MatIconModule,
      MatMenuModule,
      MatToolbarModule,

      HttpClientModule,
      MatButtonModule
    ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
