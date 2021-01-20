import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Category } from 'src/app/Models/Category';
import { Price } from 'src/app/Models/Price';
import { Wine } from 'src/app/Models/Wine';
import { WineToInsert } from 'src/app/Models/wineToInsert';
import { WineMapperService } from 'src/app/Services/Mappers/WineMapper.service';
import { WineService } from 'src/app/Services/WineService/Wine.service';

@Component({
  selector: 'app-Add-Wine',
  templateUrl: './Add-Wine.component.html',
  styleUrls: ['./Add-Wine.component.scss']
})
export class AddWineComponent implements OnInit {

  constructor(private _formBuilder: FormBuilder, private _wineService: WineService, private _mapperService : WineMapperService) { }
  actualYear: number; 
  wineForm: FormGroup;
  categories: Category[] = [];

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
    })
  }

  OnSubmit(form: NgForm) : void {
    console.group(form);
    let categoriesToAdd: Category[] = [];
    this.categories.push(form.control["category"]);
    this._wineService.insertNewWine(
      new WineToInsert(form.control["wineName"].value,
          new Price(form.control["price"]),
          form.control["year"],
          form.control["description"],
          categoriesToAdd));
  }

  setSelectedCategory(cat: Category): void {

  }

}
