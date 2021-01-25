import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ClientService } from 'src/app/Services/ClientService/Client.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-Navbar',
  templateUrl: './Navbar.component.html',
  styleUrls: ['./Navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(private _router: Router,
              private _sessionService : SessionStorageService) { }
  isProvider: boolean;
  ngOnInit() {
    
  }

  userIsProvider() : boolean {
    if(this._sessionService.recoverRoleUser() == "Provider")
    {
      return this.isProvider = true;
    }
    else 
    {
      return this.isProvider = false;
    }
  }
  userIsConnected(): boolean {    
    return this._sessionService.recoverIdUser() != null;
  }

  userLoggout() : void {
    sessionStorage.clear();
    this._sessionService.connectedUser = null;
    this._router.navigate(["/accueil"]);
  }

  getCartQt() : number {
    let qt = this._sessionService.getCartQt();
    if(qt == null) return 0;
    else return qt;
  }

  userNotLogged() : void {
    if(this._sessionService.recoverIdUser() == undefined){
      this._router.navigateByUrl("/login");
    }
  }
}
