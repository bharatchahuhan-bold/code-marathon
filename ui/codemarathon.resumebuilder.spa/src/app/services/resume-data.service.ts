import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";

@Injectable()
export class ResumeDataService {
constructor() {}

getResumeData(): Observable<any> {
    const heroes = of({});
    return heroes;
  }
}