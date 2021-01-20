import { Component, OnInit } from '@angular/core';
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

  constructor(private _wineService : WineService, private _sessionService: SessionStorageService) { }

  ngOnInit() {
    this._wineService.getWineByProviderId(this._sessionService.recoverIdUser()).subscribe(dt=>{
      this.wines.push(dt);
    });
  }

}
