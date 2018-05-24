import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http,Response, HttpModule } from '@angular/http';
import { SkillsModel } from '../models/skills-model';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw'; 

@Injectable()
export class SkillsService {

  constructor(private _http:Http) { }

  GetAllSkills(): Observable<SkillsModel[]>
  {
    return this._http.get("http://localhost:2979/api/Skills/GetAllSkills")
    .map((resp:Response)=><SkillsModel[]>resp.json())    
  }

  AddSkills(item:SkillsModel):Observable<string>
  {
    return this._http.post("http://localhost:2979/api/Skills/AddSkills/",item)
    .map((resp:Response)=><string>resp.json()) 
  }
}
