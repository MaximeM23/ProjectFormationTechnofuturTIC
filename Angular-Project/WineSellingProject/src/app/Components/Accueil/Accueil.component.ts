import { Component, OnInit } from '@angular/core';
import { Wine } from 'src/app/Models/Wine';
import { WineMapperService } from 'src/app/Services/Mappers/WineMapper.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Accueil',
  templateUrl: './Accueil.component.html',
  styleUrls: ['./Accueil.component.scss']
})
export class AccueilComponent implements OnInit {
  wineList : Wine[] = []
  constructor(private _wineService: WineService, private _wineMapper : WineMapperService) { }

  ngOnInit() {  
    this._wineService.getAllWine().subscribe(dt => {
      this.wineList = this._wineMapper.jsonToWine(dt);
    });
  }
}
