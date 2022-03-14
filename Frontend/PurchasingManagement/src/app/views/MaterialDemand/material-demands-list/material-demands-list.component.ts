import { Component, OnInit, ViewChild } from '@angular/core';
import { MaterialDemandService } from '../../../services/materialdemand/material-demand.service';
import { MaterialDemandsModel } from '../../../models/material-demands/material-demands-model';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MaterialDemandDialogComponent } from './material-demand-dialog/material-demand-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { WorkflowListModel } from '../../../models/workflow-list-model/workflow-list-model';
import { WorkflowListService } from '../../../services/workflow-list/workflow-list.service';
import { MessageService } from '../../../services/messageservice/message.service';
import { Notify } from 'notiflix/build/notiflix-notify-aio';
import { Confirm } from 'notiflix/build/notiflix-confirm-aio';
import { Loading } from 'notiflix/build/notiflix-loading-aio';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-material-demands-list',
  templateUrl: './material-demands-list.component.html',
  styleUrls: ['./material-demands-list.component.scss'],
})
export class MaterialDemandsListComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'description',
    'createdUserId',
    'createdUserName',
    'status',
    'companyId',
    'companyName',
    'actions',
  ];

  materials: MaterialDemandsModel[] = [];
  public dataSource = new MatTableDataSource<MaterialDemandsModel>(
    this.materials
  );
  @ViewChild(MatPaginator, { static: false }) paginator!: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort!: MatSort;
  @ViewChild(MatTable, { static: true }) table: MatTable<any> | any;

  page: number = 1;
  pageSize: number = 10;
  totalCount: number = 0;
  pageSizeOptions: number[] = [5, 10, 20, 50, 100];

  workflows: WorkflowListModel[] = [];
  subscription: Subscription | any;

  constructor(
    private messageService: MessageService,
    public demandsService: MaterialDemandService,
    public workflowService: WorkflowListService,
    public dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.getData(this.page, this.pageSize);
    this.dataSource.paginator = this.paginator;

    this.workflowService.getWorkflowDefinitions().subscribe((data) => {
      this.workflows = data.items;
    });
    // this.dataSource.sort = this.sort;
  }

  onRowClicked(row: any) {
    //console.log(row);
  }

  getData(page: Number, pageSize: Number) {
    //Loading.pulse('Yükleniyor..');
    this.demandsService
      .getMaterialDemands(Number(page), Number(pageSize))
      .subscribe((data) => {
        this.dataSource.data = data.data;
        this.totalCount = Number(data.data[0].totalCount);
        this.demandsService.loading = false;
        //Loading.remove();
      });
  }

  deleteDialog(obj: any): void {
    Confirm.show(
      `Kayıt Sil : ${obj.id}`,
      `${obj.description}  kayıtlı satır silinecek, onaylıyor musunuz ?`,
      'Sil',
      'İptal',
      () => {
        this.demandsService.deleteMaterialDemand(obj.id).subscribe({
          next: (v) => {
            this.dataSource.data = this.dataSource.data.filter(
              (u) => u.id !== obj.id
            );
          },
          error: (e) => {
            Notify.failure(`Kayıt silinemedi : ${e}`, {
              position: 'right-bottom',
            });
          },
          complete: () => {
            Notify.info(`${obj.description}'lı kayıt silindi`, {
              position: 'right-bottom',
            });
          },
        });
      },
      () => {
        //alert('İptal');
      }
    );
  }

  /**
       @param {boolean} value Aldığı değere göre spinner Loading gösterir/gizler */
  loadingStatus(value: boolean) {
    if (value) {
      Loading.pulse('Yükleniyor...');
      return value;
    } else {
      Loading.remove();
      return value;
    }
  }

  onChangePage(pageEvent: PageEvent) {
    this.pageSize = pageEvent.pageSize;
    this.page = +pageEvent.pageIndex + 1;
    this.getData(this.page, this.pageSize);

    this.demandsService.loading = true;
  }

  doFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLocaleLowerCase();
  }

  openDialog(action: any, obj: any) {
    obj.action = action;

    const dialogRef = this.dialog.open(MaterialDemandDialogComponent, {
      data: obj,
      autoFocus: false,
    });
    dialogRef.disableClose = true;

    // send message to subscribers via observable subject
    this.messageService.sendMessage(this.workflows);

    dialogRef.afterClosed().subscribe((result) => {
      // console.log(result);
      if (result.event == 'Ekle') {
        this.addRowData(result.data);
      } else if (result.event == 'Güncelle') {
        this.updateRowData(result.data);
      }
    });
  }

  addRowData(row_obj: any) {
    this.subscription = this.messageService
      .getMessage()
      .subscribe((message) => {
        this.dataSource.data = [message.message.data, ...this.dataSource.data];
      });
  }
  updateRowData(row_obj: any) {
    this.dataSource.data = this.dataSource.data.filter((value, key) => {
      if (value.id == row_obj.id) {
        value.description = row_obj.description;
      }
      return true;
    });
  }
}
