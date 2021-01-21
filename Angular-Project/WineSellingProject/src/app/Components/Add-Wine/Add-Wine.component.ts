import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Category } from 'src/app/Models/Category';
import { Price } from 'src/app/Models/Price';
import { Wine } from 'src/app/Models/Wine';
import { WineToInsert } from 'src/app/Models/wineToInsert';
import { WineMapperService } from 'src/app/Services/Mappers/WineMapper.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Add-Wine',
  templateUrl: './Add-Wine.component.html',
  styleUrls: ['./Add-Wine.component.scss']
})
export class AddWineComponent implements OnInit {

  constructor(private _sessionService : SessionStorageService,private _router : Router,private _formBuilder: FormBuilder, private _wineService: WineService, private _mapperService : WineMapperService) { }
  actualYear: number; 
  wineForm: FormGroup;
  categories: Category[] = [];
  selectedIdListCategory: number;

  ngOnInit() {
    this.actualYear = ((new Date()).getFullYear());
    this.wineForm = this._formBuilder.group({      
      wineName: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      price: this._formBuilder.control('1',[Validators.required]),
      year: this._formBuilder.control('1900',[Validators.required]),
      category: this._formBuilder.control('',[Validators.required]),
      description: this._formBuilder.control('',[Validators.required, Validators.minLength(3),Validators.maxLength(1000)]),
    })
    
    this._wineService.getWineCategoriesByTagId(1).subscribe(dt => {
      this.categories = dt;
    }, err => {
      this._router.navigateByUrl("/accueil");
    })
  }

  OnSubmit(form: NgForm) : void {
    this.wineForm.markAllAsTouched();
    let categoriesToAdd: Category[] = [];
    let prices : Price[] = [];
    console.log(form);
    categoriesToAdd.push(new Category(form["category"]["id"],form["category"]["categoryName"],form["category"]["tag"]["id"]));
    prices.push(new Price(form["price"]))
    let x = new WineToInsert(form["wineName"],
          prices,
          form["year"],
          form["description"],
          categoriesToAdd,
          this._sessionService.recoverIdUser())
          console.log(form);
    this._wineService.insertNewWine(x).subscribe(dt =>{
            this._router.navigateByUrl("/wineProviderList");
          });
  }

  setSelectedCategory(cat: HTMLSelectElement): void {
    this.selectedIdListCategory = parseInt(cat.value[0]);
  }

}
