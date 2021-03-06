import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Components/Navbar/Navbar.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { LoginComponent } from './Components/Login/Login.component';
import { JwtModule } from '@auth0/angular-jwt';
import { TokenInterceptorService } from './Services/Interceptor/token-interceptor.service';
import { AddressComponent } from './Components/Address/Address.component';
import { DetailsWineComponent } from './Components/Details-Wine/Details-Wine.component';
import { ShoopingCartComponent } from './Components/Shooping-Cart/Shooping-Cart.component';
import { AccueilComponent } from './Components/Accueil/Accueil.component';
import { ManageWinesComponent } from './Components/Manage-Wines/Manage-Wines.component';
import { AddWineComponent } from './Components/Add-Wine/Add-Wine.component';
import { FacturingAddressComponent } from './Components/Facturing-Address/Facturing-Address.component';
import { DetailsCommandComponent } from './Components/DetailsCommand/DetailsCommand.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

export function tokenGetter() {
  return sessionStorage.getItem("jwt");
}

@NgModule({
  declarations: [	
    AppComponent,
      NavbarComponent,
      DetailsClientComponent,
      LoginComponent,
      AddressComponent,
      DetailsWineComponent,
      ShoopingCartComponent,
      AccueilComponent,
      ManageWinesComponent,
      AddWineComponent,
      FacturingAddressComponent,
      DetailsCommandComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains:["localhost:4200"],
        disallowedRoutes:[]
      }
    }),
    NgbModule
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptorService,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
