import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { User } from '../models/user.model';
import { ResumeDataService } from '../services/resume-data.service';

@Component({
  selector: 'app-resume-builder',
  templateUrl: './resume-builder.component.html',
  styleUrls: ['./resume-builder.component.scss']
})
export class ResumeBuilderComponent implements OnInit {
  private fields: User = {};
  public isLoading: boolean = true;
  private authCode: string='';

  constructor(private resumeDataService: ResumeDataService, private route: ActivatedRoute) {}

  public ngOnInit() {
    this.route.queryParams.subscribe(params => {
      console.log('data', params);
      this.authCode = params['code'];
      this.resumeDataService.getResumeData(this.authCode).subscribe(data => {
        this.isLoading = false;
        this.fields = data;
        console.log('fields', this.fields);
      })
    });
  }
}
