import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ResumeDataService } from '../services/resume-data.service';

@Component({
  selector: 'app-resume-builder',
  templateUrl: './resume-builder.component.html',
  styleUrls: ['./resume-builder.component.scss']
})
export class ResumeBuilderComponent implements OnInit {
  authCode: string='';

  constructor(private resumeDataService: ResumeDataService, private route: ActivatedRoute) {}

  public ngOnInit() {
    // console.log('params', this.route.params);    
    // console.log('paramsMap', this.route.paramMap);
    // console.log('queryparams', this.route.queryParams);
    // console.log('queryparamsMap', this.route.queryParamMap);
    
    this.route.queryParams.subscribe(data => {
      console.log('data', data);
      this.authCode = data['code'];
      console.log(this.authCode);
    });
      
    this.resumeDataService.getResumeData(this.authCode).subscribe(data => {
      console.log(data);
    })
  }
}
