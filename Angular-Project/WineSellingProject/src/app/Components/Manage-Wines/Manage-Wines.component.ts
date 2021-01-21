import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Wine } from 'src/app/Models/Wine';
import { SessionStorageService } from 'src/app/Services/session-storage.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Manage-Wines',
  templateUrl: './Manage-Wines.component.html',
  styleUrls: ['./Manage-Wines.component.scss']
})
export class ManageWinesComponent implements OnInit {

  wines: Wine[] = []

  constructor(private _wineService : WineService, private _sessionService: SessionStorageService, private _route : Router) { }

  ngOnInit() {
    this._wineService.getWineByProviderId(this._sessionService.recoverIdUser()).subscribe(dt=>{
      this.wines.push(dt);
    },err => {
      this._route.navigateByUrl("/accueil");
    });
  }

}
