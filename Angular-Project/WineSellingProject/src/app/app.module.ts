import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Components/Navbar/Navbar.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DetailsClientComponent } from './Components/Details-Client/Details-Client.component';
import { LoginComponent } from './Components/Login/Login.component';

@NgModule({
  declarations: [	
    AppComponent,
      NavbarComponent,
      DetailsClientComponent,
      LoginComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
