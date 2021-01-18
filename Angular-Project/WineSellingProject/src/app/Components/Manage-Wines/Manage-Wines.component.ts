import { Component, OnInit } from '@angular/core';
import { Wine } from 'src/app/Models/Wine';

@Component({
  selector: 'app-Manage-Wines',
  templateUrl: './Manage-Wines.component.html',
  styleUrls: ['./Manage-Wines.component.scss']
})
export class ManageWinesComponent implements OnInit {

  wine: Wine[] = []

  constructor() { }

  ngOnInit() {
  }

}
