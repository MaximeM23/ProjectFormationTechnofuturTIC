import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Address } from 'src/app/Models/Address';
import { Cart } from 'src/app/Models/Cart';
import { Wine } from 'src/app/Models/Wine';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-Shooping-Cart',
  templateUrl: './Shooping-Cart.component.html',
  styleUrls: ['./Shooping-Cart.component.scss']
})
export class ShoopingCartComponent implements OnInit {

  cart: Cart[]
  total: number = 5;

  constructor(private _router: Router, private _sessionService : SessionStorageService) { }

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
  }

  recoverAddress(e : any) : void {
    if(e != undefined){
      
    }
  }

}
