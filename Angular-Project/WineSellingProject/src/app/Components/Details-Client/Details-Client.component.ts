import { Component, OnInit } from '@angular/core';
import { Client } from 'src/app/Models/Client';
import { ClientService } from 'src/app/Services/Client.service';
import { ClientMapperService } from 'src/app/Services/Mappers/ClientMapper.service';

@Component({
  selector: 'app-Details-Client',
  templateUrl: './Details-Client.component.html',
  styleUrls: ['./Details-Client.component.scss']
})
export class DetailsClientComponent implements OnInit {
  client: Client;
  constructor(private _clientService: ClientService, private _clientMapper: ClientMapperService) { }

  ngOnInit() {
    this._clientService.getUserById(17).subscribe((dt) =>
    {
      this.client = this._clientMapper.jsonToClient(dt);
    })
  }
  
}
