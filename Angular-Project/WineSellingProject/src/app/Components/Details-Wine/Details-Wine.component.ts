import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { WineDetails } from 'src/app/Models/WineDetails';
import { WineMapperService } from 'src/app/Services/Mappers/WineMapper.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Details-Wine',
  templateUrl: './Details-Wine.component.html',
  styleUrls: ['./Details-Wine.component.scss']
})
export class DetailsWineComponent implements OnInit {

  constructor(private _route : ActivatedRoute, private _wineService: WineService,private _mapperService : WineMapperService) { }
  idWine: string;
  wineDetails : WineDetails;
  AvgWine: number = 0;
  ngOnInit() {

    this._route.paramMap.subscribe(params => {
      this.idWine = params.get("id")
    })

    this._wineService.getWineByWineId(this.idWine).subscribe(dt => {
      this.wineDetails = this._mapperService.jsonToDetailsWine(dt);
      for(let i = 0; i < this.wineDetails.comment.length; i++)
      {        
        this.AvgWine += this.wineDetails.comment[i].note;
      }
      this.AvgWine = Math.round(this.AvgWine / this.wineDetails.comment.length);
    })

  }

}
