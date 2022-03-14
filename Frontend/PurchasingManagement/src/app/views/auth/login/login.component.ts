import { Component, OnInit } from '@angular/core';
import {AuthService} from "../../../services/auth/auth.service";
import {Router} from "@angular/router";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private authService:AuthService, private router:Router) { }

  ngOnInit(): void {
  }

  login(username:string, password:string){
    //this.authService.userAuth(username, password).subscribe(data => {
    this.authService.userAuth("test demo", "Aa123456789").subscribe(data => {
      //console.log(data);

      localStorage.setItem("access_token", data.access_token);

      /*if(data.result ==true){
        localStorage.setItem("username", data.username);
        localStorage.setItem("access_token", data.access_token);
       // this.router.navigate(["/"])
      } else {
        alert("Kullanıcı adı veya şifre hatalı");
      }*/
    });
  }
}
