import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.scss']
})
export class UserDetailComponent implements OnInit {

  constructor(private activateRoute:ActivatedRoute) { }

  ngOnInit() {
    this.activateRoute.params.subscribe(param =>{
      alert(param["id"]);
    });
  }

}
