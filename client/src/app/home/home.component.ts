import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  loginMode = false;
  registerMode = false;

  constructor(private http: HttpClient, public accountService: AccountService) { }

  ngOnInit(): void {
  }

  loginToggle() {
    this.loginMode = !this.loginMode;
  }

  cancelLoginMode(event: boolean) {
    this.loginMode = event;
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }
}
