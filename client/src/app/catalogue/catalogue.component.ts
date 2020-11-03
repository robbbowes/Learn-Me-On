import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { map } from 'rxjs/operators';
import { Course } from '../_models/course/course';

@Component({
  selector: 'app-catalogue',
  templateUrl: './catalogue.component.html',
  styleUrls: ['./catalogue.component.css']
})
export class CatalogueComponent implements OnInit {
  baseUrl = "https://localhost:5001/api/";
  courses: Course[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getCourses()
  }

  getCourses() {
    this.http.get(this.baseUrl + 'catalogue').pipe(
      map((courses: Course[]) => {
        return this.courses = courses;
      })
    ).subscribe(response => {
      console.log(response)
      this.courses = response
    })
  }

}
