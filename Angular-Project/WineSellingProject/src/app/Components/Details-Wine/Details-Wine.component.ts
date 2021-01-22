import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Cart } from 'src/app/Models/Cart';
import { Wine } from 'src/app/Models/Wine';
import { WineDetails } from 'src/app/Models/WineDetails';
import { WineMapperService } from 'src/app/Services/Mappers/WineMapper.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Details-Wine',
  templateUrl: './Details-Wine.component.html',
  styleUrls: ['./Details-Wine.component.scss']
})
export class DetailsWineComponent implements OnInit {

  constructor(private _formBuilder: FormBuilder,private _sessionService: SessionStorageService,private _route : ActivatedRoute, private _wineService: WineService,private _mapperService : WineMapperService) { }
  idWine: string;
  wineDetails : WineDetails;
  AvgWine: number = 0;
  qtForm: FormGroup;
  ngOnInit() {

    this.qtForm = this._formBuilder.group({      
      qt: this._formBuilder.control('1'),
    })

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

    IsNaN(value: number): boolean {
      if(Number.isNaN(value)) return true;
      return false;
    }

    AddToCart(wine: Wine, qt:NgForm){
      this._sessionService.storeTempCart(new Cart(wine.id,wine.wineName,wine.disabled,wine.prices[0].priceWine,qt["qt"]));
    }
}
