import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cart } from 'src/app/Models/Cart';
import { DetailsCommand } from 'src/app/Models/DetailsCommand';
import { CommandService } from 'src/app/Services/CommandService/CommandService.service';
import { CommandMapperService } from 'src/app/Services/Mappers/CommandMapper.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-DetailsCommand',
  templateUrl: './DetailsCommand.component.html',
  styleUrls: ['./DetailsCommand.component.scss']
})
export class DetailsCommandComponent implements OnInit {

  details: DetailsCommand;
  idCommand: number;
  prixTotal: number = 0;

  constructor(private _router: Router,private sessionService : SessionStorageService, private _commandService: CommandService, private _route: ActivatedRoute, private _commandMapper: CommandMapperService) { }

  ngOnInit() {

    
    this._route.paramMap.subscribe(params => {
      this.idCommand = parseInt(params.get("id"));
    })

    this._commandService.getDetailsByIdCommand(this.idCommand).subscribe(dt => {
      if(dt["client"]["id"] != this.sessionService.recoverIdUser())
      {
        this._router.navigateByUrl("/accueil");
      }

      
      this.details = this._commandMapper.jsonToDetailsCommand(dt);
      for(let i = 0 ; i < this.details.winedetails.length;i++){
        this.prixTotal = parseInt(this.prixTotal.toString()) + (this.details.winedetails[i].winePrice * this.details.winedetails[i].quantity);
      }
    });

  }

}
