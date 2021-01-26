import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Address } from 'src/app/Models/Address';
import { AddressService } from 'src/app/Services/AddressService/Address.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-Facturing-Address',
  templateUrl: './Facturing-Address.component.html',
  styleUrls: ['./Facturing-Address.component.scss']
})
export class FacturingAddressComponent implements OnInit {

  @Output() ChosenAddress = new EventEmitter<string>();

  addresses : any[] = []

  constructor(private _addressService : AddressService,private _sessionService : SessionStorageService) { }

  ngOnInit() {

    this._addressService.getAddressesByIdUser(this._sessionService.recoverIdUser()).subscribe(dt => {
      this.addresses = dt;
    });
  }

  choosedAddress(chosenAddress :Address) : void {
    this.ChosenAddress.emit(chosenAddress["id"].toString());
  }
}
