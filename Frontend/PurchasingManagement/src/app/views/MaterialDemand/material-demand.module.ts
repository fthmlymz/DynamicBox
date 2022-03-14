import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialDemandsListComponent } from './material-demands-list/material-demands-list.component';
import { MaterialDetailsComponent } from './material-details/material-details.component';
import { MaterialHistoryComponent } from './material-history/material-history.component';
import { RouterModule, Routes } from '@angular/router';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatButtonModule } from '@angular/material/button';
import { SharedModuleModule } from '../shared-components/shared-module.module';
import { MatCardModule } from '@angular/material/card';
import { MatTabsModule } from '@angular/material/tabs';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MaterialDemandDialogComponent } from './material-demands-list/material-demand-dialog/material-demand-dialog.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatDialogModule } from '@angular/material/dialog';
import { MatAutocompleteModule } from '@angular/material/autocomplete';

const routes: Routes = [
  {
    path: 'material-demands-list',
    component: MaterialDemandsListComponent,
  },
  {
    path: 'details/:id',
    component: MaterialDetailsComponent,
    children: [
      {
        path: 'material-demands-list-details',
        component: MaterialDemandsListComponent,
      },
      {
        path: 'material-demands-list-history',
        component: MaterialHistoryComponent,
      },
    ],
  },
  {
    path: '',
    //redirectTo:DocumentListComponent
    component: MaterialDemandsListComponent,
  },
];

@NgModule({
  declarations: [
    MaterialDemandsListComponent,
    MaterialDetailsComponent,
    MaterialHistoryComponent,
    MaterialDemandDialogComponent,
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    //NgxPaginationModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatIconModule,
    MatMenuModule,
    MatButtonModule,
    SharedModuleModule,
    MatCardModule,
    MatTabsModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatDialogModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
  ],
})
export class MaterialDemandModule {}
