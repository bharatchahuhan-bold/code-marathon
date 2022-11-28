import { Component, OnInit } from '@angular/core';
import { ResumeDataService } from '../services/resume-data.service';

@Component({
  selector: 'app-resume-builder',
  templateUrl: './resume-builder.component.html',
  styleUrls: ['./resume-builder.component.scss']
})
export class ResumeBuilderComponent implements OnInit {

  constructor(private resumeDataService: ResumeDataService) {}

  public ngOnInit() {
this.resumeDataService.getResumeData()
  }
}
