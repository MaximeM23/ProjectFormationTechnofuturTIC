import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccueilComponent } from './Components/Accueil/Accueil.component';
import { AddWineComponent } from './Components/Add-Wine/Add-Wine.component';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { DetailsWineComponent } from './Components/Details-Wine/Details-Wine.component';
import { DetailsCommandComponent } from './Components/DetailsCommand/DetailsCommand.component';
import { FacturingAddressComponent } from './Components/Facturing-Address/Facturing-Address.component';
import { LoginComponent } from './Components/Login/Login.component';
import { ManageWinesComponent } from './Components/Manage-Wines/Manage-Wines.component';
import { ShoopingCartComponent } from './Components/Shooping-Cart/Shooping-Cart.component';
import { AuthGuardService } from './Guards/auth-guard.service';

const routes: Routes = [
  {
    path:'',
    component:AccueilComponent,
  },
  {
    path: 'accueil',
    component:AccueilComponent,    
  },
  {
    path: 'details',
    component:DetailsClientComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'detailsWine/:id',
    component: DetailsWineComponent
  },
  {
    path: 'shoopingCart',
    component: ShoopingCartComponent
  },
  {
    path: 'wineProviderList',
    component: ManageWinesComponent
  },
  {
    path: 'addWine',
    component: AddWineComponent
  },
  {
    path: 'FactAddress',
    component: FacturingAddressComponent
  },
  {
    path: 'detailsCommand/:id',
    component: DetailsCommandComponent
  },
  {
    path:"**",
    component: AccueilComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
