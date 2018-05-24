import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Http,HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { SkillsComponent } from './views/skills/skills.component';
import { AssociateComponent } from './views/associate/associate.component';
import { SkillsService } from './services/skills.service';
import { AssociateService } from './services/associate.service';
import { DashboardService } from './services/dashboard.service';
import { DashboardComponent } from './Views/dashboard/dashboard.component';


@NgModule({
  declarations: [
    AppComponent,
    SkillsComponent,
    AssociateComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule
  ],
  providers: [SkillsService, AssociateService],
  bootstrap: [AppComponent]
})
export class AppModule { }
