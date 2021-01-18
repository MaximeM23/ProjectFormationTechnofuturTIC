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
  filteredWineList: Wine[] = []

  redWineFilterActive : boolean = false;
  whiteWineFilterActive : boolean = false;
  roseWineFilterActive : boolean = false;
  noWineFilterActive : boolean = true;

  constructor(private _wineService: WineService, private _wineMapper : WineMapperService) { }

  ngOnInit() {  
    this._wineService.getAllWine().subscribe(dt => {
      this.wineList = this._wineMapper.jsonToWine(dt);
      this.filteredWineList = this.wineList;
    });
  }

  filterRedWine(): void {
    this.filteredWineList = []
    this.filteredWineList = this.wineList.filter(x => x.category[0].categoryName == "Vin rouge");
      
    this.redWineFilterActive = true;
    this.whiteWineFilterActive = false;
    this.roseWineFilterActive = false;
    this.noWineFilterActive = false;
  }

  filterWhiteWine(): void {
    this.filteredWineList = []
    this.filteredWineList = this.wineList.filter(x => x.category[0].categoryName == "Vin blanc");

    
    this.redWineFilterActive = false;
    this.whiteWineFilterActive = true;
    this.roseWineFilterActive = false;
    this.noWineFilterActive = false;
  }

  filterRoseWine() : void {
    this.filteredWineList = []
    this.filteredWineList = this.wineList.filter(x => x.category[0].categoryName == "Vin rosé");

    
    this.redWineFilterActive = false;
    this.whiteWineFilterActive = false;
    this.roseWineFilterActive = true;
    this.noWineFilterActive = false;
  }

  noWineFilter(): void {
    this.filteredWineList = this.wineList;
    
    this.redWineFilterActive = false;
    this.whiteWineFilterActive = false;
    this.roseWineFilterActive = false;
    this.noWineFilterActive = true;
  }
}
