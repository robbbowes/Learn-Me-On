import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  @Output() cancelLogin = new EventEmitter();
  model: any = {};

  constructor(public accountService: AccountService, private toastrService: ToastrService) { }
  ngOnInit(): void {
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error => {
      console.log(error);
      this.toastrService.error(error.error);
    })
  }

  cancel() {
    this.cancelLogin.emit(false);
  }

}
