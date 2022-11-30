import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";


@Injectable()
export class ResumeDataService {
constructor(private http: HttpClient) {}

getResumeData(code: string): Observable<any> {
  return this.http.get("https://localhost:5001/api/user/v1/getUserDetails?authCode=" + code);
    //.subscribe((data) ⇒ console.log(data))
  }
}