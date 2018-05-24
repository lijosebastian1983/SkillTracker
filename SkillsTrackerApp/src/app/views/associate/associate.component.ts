import { Component, OnInit } from '@angular/core';
import { AssociateModel } from '../../models/associate-model';
import { AssociateSkillsModel } from '../../models/associate-skills-model';
import { AssociateService } from '../../services/associate.service';
import { SkillsService } from '../../services/skills.service';
import { SkillsModel } from '../../models/skills-model';

@Component({
  selector: 'app-associate',
  templateUrl: './associate.component.html',
  styleUrls: ['./associate.component.css']
})
export class AssociateComponent implements OnInit {

  constructor(private _service:AssociateService, private _skillsService:SkillsService){ }
  associate: AssociateModel = new AssociateModel();
  message: string;
  associateSkills: AssociateSkillsModel[];
  skillsList :SkillsModel[];
  skillListArray: any[];
  ngOnInit() {
    this.GetAllAssociateSkills()    
  }

  AddAssociateDetails()
  {      
    this.associate.AssociateSkills =  this.associateSkills;
    this._service.AddAssociateDetails(this.associate)
    .subscribe(p=>this.message=p) ;          
    this.associate = null;
  }
  GetAllSkills()
  {
    this._skillsService.GetAllSkills()
    .subscribe(P => this.skillsList=P);
  }
  GetAssociateByID()
  {
  }
  GetAllAssociateSkills()
  {
    this._service.GetAllAssociateSkills()
    .subscribe(P => this.associateSkills=P);
  }

  

BuildTreeColumnArr(theArr: AssociateSkillsModel[]){
    for(var i = 0; i < theArr.length ; i+=4) {
        var row = [];

        for(var x = 0; x < 4; x++) {
          var value = theArr[i + x];
            if (!value) {
                break;
            }
            row.push(value);
        }
        this.skillListArray.push(row);
    }     
}
}
