import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MymenuComponent } from './mymenu/mymenu.component';
import { LikeComponent } from './like/like.component';
import { MovieComponent } from './movie/movie.component';
import { FlowersComponent } from './flowers/flowers.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieService } from './movie/movie.service';
import { MoviecartComponent } from './moviecart/moviecart.component';
import { SimpleComponent } from './simple/simple.component';
import { CustomerComponent } from './customer/customer.component';
import { CustomersComponent } from './customers/customers.component';
import {CustomerService} from './customer/customer.service';

@NgModule({
  declarations: [
    AppComponent,
    MymenuComponent,
    LikeComponent,
    MovieComponent,
    FlowersComponent,
    MoviesComponent,
    MoviecartComponent,
    SimpleComponent,
    CustomerComponent,
    CustomersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [MovieService,CustomerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
