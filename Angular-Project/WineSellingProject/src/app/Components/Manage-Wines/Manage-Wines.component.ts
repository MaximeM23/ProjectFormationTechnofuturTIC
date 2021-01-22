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
      for(let i = 0; i < dt.length; i++)
      {
        this.wines.push(dt[i]);
      }
    },err => {
      this._route.navigateByUrl("/accueil");
    });
  }

  DisableWine(id: number) : void {
    if(id>0)
    {
      this._wineService.disableWine(id).subscribe(dt => {
        this.wines[this.wines.findIndex(x => x.id == id)].disabled = true;
      });
    }
  }

  EnableWine(id: number) : void {
    if(id>0)
    {
      this._wineService.enableWine(id).subscribe(dt => {
        this.wines[this.wines.findIndex(x => x.id = id)].disabled = false;
      })
    }
  }

}
