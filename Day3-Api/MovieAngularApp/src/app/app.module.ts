import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {MovieService} from './services/movieService';

import {HttpClientModule} from '@angular/common/http';
import { ShowmoviesComponent } from './showmovies/showmovies.component';
import { AddmovieComponent } from './addmovie/addmovie.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowmoviesComponent,
    AddmovieComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [MovieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
