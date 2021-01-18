import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccueilComponent } from './Components/Accueil/Accueil.component';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { DetailsWineComponent } from './Components/Details-Wine/Details-Wine.component';
import { LoginComponent } from './Components/Login/Login.component';
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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
