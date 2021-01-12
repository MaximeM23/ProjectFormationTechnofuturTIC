import { Component, OnInit, Input } from '@angular/core';
import { Address } from 'src/app/Models/Address';
import { AddressService } from 'src/app/Services/AddressService/Address.service';

@Component({
  selector: 'app-Address',
  templateUrl: './Address.component.html',
  styleUrls: ['./Address.component.scss']
})
export class AddressComponent implements OnInit {

  @Input() addresses: Address[]
  constructor() { }

  ngOnInit() {
    console.log(this.addresses);
    
  }



}
