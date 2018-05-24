import { Component, OnInit } from '@angular/core';
import { AssociateModel } from '../../models/associate-model';
import { DashboardService } from '../../services/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  associatesModel :AssociateModel[];
  constructor(private _service:DashboardService) { }

  ngOnInit() {
    this.GetAllAssociates();
  }
  GetAllAssociates()
  {
    this._service.GetAllAssociates()
    .subscribe(P => this.associatesModel=P)
  }

}
