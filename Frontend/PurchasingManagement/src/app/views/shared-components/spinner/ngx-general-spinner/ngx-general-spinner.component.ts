import { Component, OnInit } from '@angular/core';
import {NgxSpinnerService} from "ngx-spinner";
import { Injectable } from '@angular/core'; // at top

@Component({
  selector: 'app-ngx-general-spinner',
  templateUrl: './ngx-general-spinner.component.html',
  styleUrls: ['./ngx-general-spinner.component.scss']
})
@Injectable({
  providedIn: 'root' // just before your class
})

export class NgxGeneralSpinnerComponent implements OnInit {

  constructor(
    public spinner: NgxSpinnerService
  ) { }

  ngOnInit(): void {
  }

}
