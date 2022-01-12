import { Component, OnInit } from '@angular/core';
import { ToastrService,} from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner'

@Component({
  selector: 'app-document-list',
  templateUrl: './document-list.component.html',
  styleUrls: ['./document-list.component.scss']
})
export class DocumentListComponent implements OnInit {

  constructor(
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ) {}

  ngOnInit() {
    this.showSuccess();
    this.showSpinner();
  }

  showSuccess() {
    this.toastr.success("Merhaba", 'toastr fun!')
  }


  showSpinner(){
    this.spinner.show();
    setTimeout(() => {
      this.spinner.hide();
    }, 5000)
  }
}
