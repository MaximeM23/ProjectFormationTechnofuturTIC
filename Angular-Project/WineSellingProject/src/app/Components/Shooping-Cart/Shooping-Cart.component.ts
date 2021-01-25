import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Address } from 'src/app/Models/Address';
import { Cart } from 'src/app/Models/Cart';
import { Command } from 'src/app/Models/Command';
import { CommandWine } from 'src/app/Models/CommandWine';
import { Wine } from 'src/app/Models/Wine';
import { CommandService } from 'src/app/Services/CommandService/CommandService.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-Shooping-Cart',
  templateUrl: './Shooping-Cart.component.html',
  styleUrls: ['./Shooping-Cart.component.scss']
})
export class ShoopingCartComponent implements OnInit {

  cart: Cart[]
  total: number = 5;
  addressSelected: boolean = false;
  idAddressSelected : number = 0;

  constructor(private _router: Router, private _sessionService : SessionStorageService, private _commandService:  CommandService) { }

  ngOnInit() {
    this.cart = this._sessionService.getTempCart();
    for(let i = 0; i < this.cart.length; i++){      
      this.total = parseInt(this.total.toString()) + (parseInt(this.cart[i].price.toString()) * this.cart[i].quantity);
    }
  }

  payCart() : void {
    if(this._sessionService.recoverIdUser() == undefined){
      this._router.navigateByUrl("/login");
    }
    else {
      let cmdWine : CommandWine[] = [];
      for(let i = 0; i < this.cart.length; i++)
      {
        cmdWine.push(new CommandWine(this.cart[i].quantity,this.cart[i].id));
      }
      let cmd : Command;
      cmd = new Command(0,this._sessionService.recoverIdUser(),this.idAddressSelected,cmdWine);      
      this._commandService.sendCommandToApi(cmd);
    }
  }

  recoverAddress(e : any) : void {
    if(e != undefined){
      this.addressSelected = true;
      this.idAddressSelected = e;
    }
  }

}
