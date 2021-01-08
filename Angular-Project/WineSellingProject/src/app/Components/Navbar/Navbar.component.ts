import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ClientService } from 'src/app/Services/Client.service';

@Component({
  selector: 'app-Navbar',
  templateUrl: './Navbar.component.html',
  styleUrls: ['./Navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(private _clientService: ClientService,
              private _router: Router) { }

  ngOnInit() {
  }

  userIsConnected(): boolean {
    return this._clientService.connectedClient != null
  }

  userLoggout() : void {
    sessionStorage.clear();
    this._clientService.connectedClient = null;
    this._router.navigate(["/accueil"]);
  }


}
