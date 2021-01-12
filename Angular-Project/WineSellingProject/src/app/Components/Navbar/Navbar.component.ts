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

  constructor(private _clientService: ClientService,
              private _router: Router,
              private _sessionService : SessionStorageService) { }

  ngOnInit() {
  }

  userIsConnected(): boolean {
    return this._sessionService.recoverIdUser() != null;
  }

  userLoggout() : void {
    sessionStorage.clear();
    this._clientService.connectedClient = null;
    this._router.navigate(["/accueil"]);
  }


}
