import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";


@Injectable()
export class ResumeDataService {
constructor(private http: HttpClient) {}

getResumeData(accessCode: string): Observable<any> {
  return this.http.get("https://localhost:5001/api/User", {
    headers : {'Authorization': accessCode}
 });
  //subscribe((data) ⇒ console.log(data))
  }
}