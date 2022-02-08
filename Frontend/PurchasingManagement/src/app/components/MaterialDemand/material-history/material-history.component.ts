import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-material-history',
  templateUrl: './material-history.component.html',
  styleUrls: ['./material-history.component.scss']
})
export class MaterialHistoryComponent implements OnInit {
  displayedColumns : string[] = [
    'id',
    'definitionId',
    'tenantId',
    'version',
    'workflowStatus',
    'correlationId',
    'contextType',
    'contextId',
    'name',
    'createdAt',
    'lastExecutedAt',
    'finishedAt',
    'cancelledAt',
    'faultedAt',
    'data',
    'lastExecutedActivityId',
    'materialDemandId',
    'businessCode'
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
