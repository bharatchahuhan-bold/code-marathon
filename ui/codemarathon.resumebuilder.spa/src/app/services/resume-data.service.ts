import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";


@Injectable()
export class ResumeDataService {
constructor(private http: HttpClient) {}

getResumeData(): Observable<any> {
  return this.http.get("http://jsonplaceholder.typicode.com/users");
  //subscribe((data) ⇒ console.log(data))
  }
}