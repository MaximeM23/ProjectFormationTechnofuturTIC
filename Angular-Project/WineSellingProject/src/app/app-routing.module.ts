import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { LoginComponent } from './Components/Login/Login.component';

const routes: Routes = [
  {
    path: 'accueil',
    component:DetailsClientComponent
  },
  {
    path: 'login',
    component: LoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
