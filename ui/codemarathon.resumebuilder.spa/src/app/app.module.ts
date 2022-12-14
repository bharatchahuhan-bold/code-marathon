import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { ResumeBuilderComponent } from './resume-builder/resume-builder.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MaterialModule } from './material.module';
import { HttpClientModule } from '@angular/common/http';
import { ResumeDataService } from './services/resume-data.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ResumeBuilderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule
  ],
  providers: [
    ResumeDataService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
