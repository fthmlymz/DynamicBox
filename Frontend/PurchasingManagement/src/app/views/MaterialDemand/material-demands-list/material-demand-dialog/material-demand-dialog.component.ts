import {
  Component,
  Inject,
  Injectable,
  Input,
  OnDestroy,
  OnInit,
  Optional,
  ViewChild,
} from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MaterialDemandsModel } from '../../../../models/material-demands/material-demands-model';
import { WorkflowListModel } from '../../../../models/workflow-list-model/workflow-list-model';
import { map, startWith } from 'rxjs/operators';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Observable, Subscription } from 'rxjs';
import { MessageService } from '../../../../services/messageservice/message.service';
import jwtDecode, { JwtPayload } from 'jwt-decode';
import { MaterialDemandService } from '../../../../services/materialdemand/material-demand.service';
import { MaterialDemandsListComponent } from '../material-demands-list.component';
import { Notify } from 'notiflix/build/notiflix-notify-aio';

@Component({
  selector: 'app-material-demand-dialog',
  templateUrl: './material-demand-dialog.component.html',
  styleUrls: ['./material-demand-dialog.component.scss'],
})
@Injectable({
  providedIn: 'root', // just before your class
})
export class MaterialDemandDialogComponent implements OnInit, OnDestroy {
  action: string | any;
  local_data: any;

  workflows: WorkflowListModel[] = []; //Workflow list

  workflowsCtrl = new FormControl(); //autoComplete states
  filteredStates: Observable<string[]> | any;
  subscription: Subscription | any;

  @Input() material = {
    id: null,
    description: null,
    ldapId: null,
    sAMAAccountName: null,
    objectGuid: null,
    email: null,
    prefferedUserName: null,
    manager: null,
    companyName: null,
    status: null,

    workflowId: null,
    workflowDefinitionId: null,
    workflowName: null,
    workflowVersion: null,
    companyId: '1',
  };
  ownerForm: FormGroup | any;

  constructor(
    private fb: FormBuilder,
    private messageService: MessageService,
    private materialDemandService: MaterialDemandService,
    public dialogRef: MatDialogRef<MaterialDemandDialogComponent>,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: MaterialDemandsModel
  ) {
    this.local_data = { ...data };
    this.action = this.local_data.action;

    // subscribe to material-demands-list component -> workflow list messages
    this.subscription = this.messageService
      .getMessage()
      .subscribe((message) => {
        this.workflows = message.message;
        if (message) {
          //this.workflows.push(message.message);
        } else {
          this.workflows = [];
        }
      });

    //First opened, set material
    this.material = {
      id: this.local_data.id,
      description: this.local_data.description,
      ldapId: this.local_data.ldapId,
      sAMAAccountName: this.local_data.sAMAAccountName,
      objectGuid: this.local_data.objectGuid,
      email: this.local_data.email,
      prefferedUserName: this.local_data.prefferedUserName,
      manager: this.local_data.manager,
      companyName: this.local_data.companyName,
      status: this.local_data.status,

      workflowId: this.local_data.workflowId,
      workflowDefinitionId: this.local_data.workflowDefinitionId,
      workflowName: this.local_data.workflowName,
      workflowVersion: this.local_data.workflowVersion,
      companyId: this.local_data.companyId,
    };
  }

  ngOnInit(): void {
    this.filteredStates = this.workflowsCtrl.valueChanges.pipe(
      startWith(''),
      map((state) =>
        state ? this._filterStates(state) : this.workflows.slice()
      )
    );

    //Get Token Information
    this.getTokenUserInformation();

    //Validators
    this.ownerForm = this.fb.group({
      description: [
        this.local_data.description,
        [Validators.maxLength(250), Validators.required],
      ],
      workflowName: [
        this.local_data.workflowName,
        [Validators.maxLength(150), Validators.required],
      ],
      workflowId: [
        this.local_data.workflowId,
        [Validators.maxLength(150), Validators.required],
      ],
    });
  }

  //AutoComplete -> workflows search
  private _filterStates(value: string): WorkflowListModel[] {
    const filterValue = value.toLowerCase();
    return this.workflows.filter((state) =>
      state.displayName.toLowerCase().includes(filterValue)
    );
  }

  //setWorkflowInfo
  setWorkflowInfo(value: any) {
    //console.log(value);
    this.material.workflowName = value.name;
    this.material.workflowDefinitionId = value.definitionId;
    this.material.workflowId = value.id;
    this.material.workflowVersion = value.version;
  }

  //Token payload => get manager value
  getTokenUserInformation() {
    const decoded = jwtDecode<JwtPayload>(
      String(localStorage.getItem('access_token'))
    );

    return Object.keys(decoded).forEach((k, i) => {
      //console.log( Object.keys(decoded)[i], Object.values(decoded)[i]);

      //manager
      if (Object.keys(decoded)[i] === 'manager') {
        this.material.manager = Object.values(decoded)[i].slice(
          3,
          Object.values(decoded)[i].indexOf(',')
        );
        return Object.values(decoded)[i].slice(
          3,
          Object.values(decoded)[i].indexOf(',')
        );
      }
      //LDAP_ENTRY_DN
      if (Object.keys(decoded)[i] === 'LDAP_ENTRY_DN') {
        this.material.companyName = Object.values(decoded)
          [i].split(',')[1]
          .substr(3);
        return Object.values(decoded)[i].split(',')[1].substr(3);
      }
      //sAMAccountName
      if (Object.keys(decoded)[i] === 'sAMAccountName') {
        this.material.sAMAAccountName = Object.values(decoded)[i];
        return Object.values(decoded)[i];
      }
      //objectGUID
      if (Object.keys(decoded)[i] === 'objectGUID') {
        this.material.objectGuid = Object.values(decoded)[i];
        return Object.values(decoded)[i];
      }
      //preferred_username
      if (Object.keys(decoded)[i] === 'preferred_username') {
        this.material.prefferedUserName = Object.values(decoded)[i];
        return Object.values(decoded)[i];
      }
      //email
      if (Object.keys(decoded)[i] === 'email') {
        this.material.email = Object.values(decoded)[i];
        return Object.values(decoded)[i];
      }
      //LDAP_ID
      if (Object.keys(decoded)[i] === 'LDAP_ID') {
        this.material.ldapId = Object.values(decoded)[i];
        return Object.values(decoded)[i];
      }
    });
  }

  /**
   * @param {string} description Açıklama alanı
   * @param {string} createdUserId Kullanıcı id numarası
   * @param {string} createdUserName Oluşturan kullanıcı adı
   * @param {string} status Talep durumu -> standart idle
   * @param {string} companyId Şirket kodu gerekli fakat silinecek
   * @param {string} manager Oluşturan kullanıcının yönetici adı
   * @param {string} companyName Şirket adı
   */
  postMaterialDemand(): void {
    this.materialDemandService
      .postMaterialWithObservable(this.material)
      .subscribe({
        next: (res) => {
          this.messageService.sendMessage(res);
        },
        error: (e) => {
          Notify.success(`Hata oluştu : ${e}`, { position: 'right-bottom' });
        },
        complete: () => {
          Notify.success(`Talep kaydedildi.`, { position: 'right-bottom' });
        },
      });
  }

  putMaterialDemand(): void {
    this.materialDemandService.putMaterialDemand(this.material).subscribe({
      next: (res) => {
        console.log(res);
      },
      error: (e) => {
        Notify.failure(`Hata oluştu : ${e}`, { position: 'right-bottom' });
      },
      complete: () => {
        Notify.success(`Talep güncellendi`, { position: 'right-bottom' });
      },
    });
  }

  doAction() {
    if (this.action === 'Ekle') {
      this.postMaterialDemand();
    } else if (this.action === 'Düzenle') {
      this.putMaterialDemand();
    }
    this.dialogRef.close({ event: this.action, data: this.local_data });
  }
  closeDialog() {
    this.dialogRef.close({ event: 'Kapat' });
  }
  ngOnDestroy(): void {
    // unsubscribe to ensure no memory leaks
    this.subscription.unsubscribe();
  }
}
