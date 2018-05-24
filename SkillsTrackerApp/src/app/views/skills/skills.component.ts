import { Component, OnInit } from '@angular/core';
import { SkillsService } from '../../services/skills.service';
import { SkillsModel } from '../../models/skills-model';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.css']
})
export class SkillsComponent implements OnInit {
  skillsList :SkillsModel[];
  skillsModel:SkillsModel = new SkillsModel();
  message:string;
  constructor(private _service:SkillsService) { }

  ngOnInit() {
    this.GetAllSkills();
    this.message= '';
  }

  GetAllSkills()
  {
    this._service.GetAllSkills()
    .subscribe(P => this.skillsList=P)
  }
  AddSkills()
  {
    this.message= '';
    this._service.AddSkills(this.skillsModel)
    .subscribe(p=> this.message=p)
    
    this._service.GetAllSkills()
    .subscribe(P => this.skillsList=P)
  } 
}
