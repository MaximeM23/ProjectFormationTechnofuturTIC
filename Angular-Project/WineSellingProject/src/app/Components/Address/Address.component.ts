import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Address } from 'src/app/Models/Address';
import { City } from 'src/app/Models/City';
import { AddressService } from 'src/app/Services/AddressService/Address.service';
import { CityService } from 'src/app/Services/AddressService/City.service';
import { CityMapper } from 'src/app/Services/Mappers/Mapper';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

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
  constructor(private _sessionService: SessionStorageService, private _addressService: AddressService,private _CityMapper: CityMapper,private _CityService : CityService, private _formBuilder: FormBuilder) { }

  ngOnInit() {
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
    console.log(id, form["country"]);
    this._addressService.UpdateAddress(new Address(id,
                                                    form["street"],
                                                    form["number"],
                                                    new City(0,form["country"],
                                                    form["postalCode"],
                                                    form["city"])
                    )).subscribe(dt =>{
                      console.log(dt);
            });
      location.reload();
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

    this._CityService.getCities(address.City.Country).subscribe(dt => {
      this.cities = dt;
    })
    
    this._CityService.getCP(address.City.CityName).subscribe(dt => {
      this.postalCode = dt;
    })

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
      city: this._formBuilder.control('',[Validators.required]),
      country: this._formBuilder.control('',[Validators.required]),
      street: this._formBuilder.control('',[Validators.required]),
      number: this._formBuilder.control('',[Validators.required,Validators.minLength(1),Validators.maxLength(8)]),
      postalCode: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),                  
    });

  }

  OnAdd(): void {

  }
  setSelectedCountry(value: HTMLSelectElement): void {
    this._CityService.getCities(value.value.slice(3,value.value.length)).subscribe(dt => {
      this.cities = dt;
    })
  }
  setSelectedCity(value :HTMLSelectElement) : void {
    this._CityService.getCP(value.value.slice(3,value.value.length)).subscribe(dt => {
      this.postalCode = dt;
    })
  }

  AddAddressToUser(value: NgForm): void {
    this._addressService.InsertAddressForUser(new Address(0,
                                                          value.controls["street"].value,
                                                          value.controls["number"].value,
                                                          new City(0,value.controls["country"].value,
                                                          value.controls["postalCode"].value,
                                                          value.controls["city"].value)
                                                          ),this._sessionService.recoverIdUser()).subscribe(dt =>{
                                                            console.log(dt);
                                                          });
    location.reload();
  }
}
