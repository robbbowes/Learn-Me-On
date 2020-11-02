import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css']
})
export class TestErrorsComponent implements OnInit {
  baseUrl = 'https://localhost:5001/api/';
  validationErrors: string[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  private getHelper(url: string) {
    this.http.get(this.baseUrl + url).subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    })
  }

  get404Error() {
    this.getHelper('bug/not-found');
  }

  get400Error() {
    this.getHelper('bug/bad-request');
  }

  get500Error() {
    this.getHelper('bug/server-error');
  }

  get401Error() {
    this.getHelper('bug/auth');
  }

  get400ValidationError() {
    this.http.post(this.baseUrl + 'account/register', {}).subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
      this.validationErrors = error;
    })
  }

}
