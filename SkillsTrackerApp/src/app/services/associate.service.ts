import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http,Response, HttpModule } from '@angular/http';
import { AssociateModel } from '../models/associate-model';
import { AssociateSkillsModel } from '../models/associate-skills-model';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw'; 
@Injectable()
export class AssociateService {
  constructor(private _http:Http) { }
  AddAssociateDetails(item: AssociateModel):Observable<string>
  {
    return this._http.post("http://localhost:2979/api/Associate/AddAssociateDetails/", item)
    .map((resp:Response)=> <string>resp.json())
  }
  GetAllAssociateSkills(): Observable<AssociateSkillsModel[]>
  {
    return this._http.get("http://localhost:2979/api/Associate/GetAllAssociateSkills")
    .map((resp:Response)=><AssociateSkillsModel[]>resp.json())    
  }
}
