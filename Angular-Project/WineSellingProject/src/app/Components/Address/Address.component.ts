import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Address } from 'src/app/Models/Address';
import { City } from 'src/app/Models/City';
import { AddressService } from 'src/app/Services/AddressService/Address.service';
import { CityService } from 'src/app/Services/AddressService/City.service';
import { CityMapper } from 'src/app/Services/Mappers/Mapper';

@Component({
  selector: 'app-Address',
  templateUrl: './Address.component.html',
  styleUrls: ['./Address.component.scss']
})
export class AddressComponent implements OnInit {

  @Input() addresses: Address[]
  addressForm: FormGroup;
  cities: string[] = []
  countries: string[] = []
  postalCode: string[] = []

  ClickedForInsert: boolean = false;  
  Clicked: boolean = false;
  UpdateShown: boolean = false;
  ClickedIndex : number;
  constructor(private _CityMapper: CityMapper,private _CityService : CityService, private _formBuilder: FormBuilder) { }

  ngOnInit() {/*
      this._CityService.getAll().subscribe(dt => {
        this.cities = this._CityMapper.jsonToCity(dt);
        for(let i = 0; i < this.cities.length;i++)
        {
          if(!this.countries.find(x => x == this.cities[i].Country))
          {
            this.countries.push(this.cities[i].Country);
          }
          /*
          if(!this.citiesString.find(x => x == this.cities[i].CityName))
          {
            this.citiesString.push(this.cities[i].CityName);
          }
          /*
          if(!this.citiesString.find(x => x == this.cities[i].CityName))
          {
            this.citiesString.push(this.cities[i].CityName);
          }*/
      this._CityService.getCountries().subscribe(dt => {
        this.countries = dt;
      })
      this.addressForm = this._formBuilder.group({
        city: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        country: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        street: this._formBuilder.control('',[Validators.required]),
        number: this._formBuilder.control('',[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
        postalCode: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),                      
      });
    }    
  

  OnUpdate(id: number, form: NgForm) : void{

  }


  toggleFormUpdate(address: Address) : void {
    this.ClickedIndex = address.Id;
    this.addressForm = this._formBuilder.group({
      city: this._formBuilder.control(address.City.CityName,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      country: this._formBuilder.control(address.City.Country,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      street: this._formBuilder.control(address.Street,[Validators.required]),
      number: this._formBuilder.control(address.Number,[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
      postalCode: this._formBuilder.control(address.City.PostalCode,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),                  
    });

    this.Clicked = true;    
    this.UpdateShown = true;
  }

  removeFormUpdate(): void {
    this.Clicked = false;
    this.UpdateShown = false;
  }

  RemoveFormInsert(): void {
    this.ClickedForInsert = false;
    this.postalCode = [];
    this.cities = [];    
  }

  AddformInsert(): void {
    this.ClickedForInsert = true;    
    this.addressForm = this._formBuilder.group({
      city: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      country: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      street: this._formBuilder.control('',[Validators.required]),
      number: this._formBuilder.control('',[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
      postalCode: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),                  
    });

  }

  OnAdd(): void {

  }
  setSelectedCountry(value: HTMLSelectElement): void {
    this._CityService.getCities(value.value).subscribe(dt => {
      this.cities = dt;
    })
  }
  setSelectedCity(value :HTMLSelectElement) : void {
    this._CityService.getCP(value.value).subscribe(dt => {
      console.log(dt);
      this.postalCode = dt;
    })
  }


}
