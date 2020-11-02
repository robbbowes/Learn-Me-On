import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  @Output() cancelLogin = new EventEmitter();
  model: any = {};

  constructor(public accountService: AccountService) { }
  ngOnInit(): void {
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error => {
      console.log(error);
    })
  }

  cancel() {
    this.cancelLogin.emit(false);
  }

}
