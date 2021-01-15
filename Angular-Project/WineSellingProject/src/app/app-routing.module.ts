import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccueilComponent } from './Components/Accueil/Accueil.component';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { DetailsWineComponent } from './Components/Details-Wine/Details-Wine.component';
import { LoginComponent } from './Components/Login/Login.component';
import { AuthGuardService } from './Guards/auth-guard.service';

const routes: Routes = [
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
    path: 'detailsWine',
    component: DetailsWineComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
