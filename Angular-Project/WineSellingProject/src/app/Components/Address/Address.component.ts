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
  cities: City[] = []
  ClickedForInsert: boolean = false;  
  Clicked: boolean = false;
  ClickedIndex : number;
  constructor(private _CityMapper: CityMapper,private _CityService : CityService, private _formBuilder: FormBuilder) { }

  ngOnInit() {
      this._CityService.getAll().subscribe(dt => {
        this.cities = this._CityMapper.jsonToCity(dt);
        this.addressForm = this._formBuilder.group({
          city: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
          country: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
          street: this._formBuilder.control('',[Validators.required]),
          number: this._formBuilder.control('',[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
          postalCode: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),        
              
        });
      });
      
  }

  OnUpdate(id: number, form: NgForm) : void{

  }


  toggleFormUpdate(address: Address) : void {

    this.addressForm = this._formBuilder.group({
      city: this._formBuilder.control(address.City.CityName,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      country: this._formBuilder.control(address.City.Country,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
      street: this._formBuilder.control(address.Street,[Validators.required]),
      number: this._formBuilder.control(address.Number,[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
      postalCode: this._formBuilder.control(address.City.PostalCode,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),        
          
    });

    this.Clicked = true;
  }

  removeFormUpdate(): void {
    this.Clicked = false;
  }

  RemoveFormInsert(): void {
    this.ClickedForInsert = false;
  }

  AddformInsert(): void {
    this.ClickedForInsert = true;
  }

  OnAdd(): void {

  }




}
