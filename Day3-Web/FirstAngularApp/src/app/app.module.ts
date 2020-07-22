import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {RouterModule,Routes} from '@angular/router';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MymenuComponent } from './mymenu/mymenu.component';
import { LikeComponent } from './like/like.component';
import { MovieComponent } from './movie/movie.component';
import { FlowersComponent } from './flowers/flowers.component';
import { MoviesComponent } from './movies/movies.component';
import {FoodComponent} from './food/food.component'
import {EmployeeComponent} from './employee/employee.component';
import { MovieService } from './movie/movie.service';
import { MoviecartComponent } from './moviecart/moviecart.component';
import { SimpleComponent } from './simple/simple.component';
import { CustomerComponent } from './customer/customer.component';
import { CustomersComponent } from './customers/customers.component';
import {CustomerService} from './customer/customer.service';
import { SalaryComponent } from './salary/salary.component';
import { UserComponent } from './user/user.component';
import {UserService} from './user/user.service';
import { SampleComponent } from './sample/sample.component';

var myRoutes:Routes=[
  {path:"customer",component:CustomersComponent},
  {path:"movie",component:MoviesComponent},
  {path:"food",component:FoodComponent},
  {path:"like",component:LikeComponent},
  {path:"",component:FlowersComponent},
  {path:"employee",component:EmployeeComponent,children:[
    {path:"salary",component:SalaryComponent},
    {path:"simple",component:SimpleComponent}
  ]},
  
  {path:'user',component:UserComponent},
  {path:'**',component:MymenuComponent}
]


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
    CustomersComponent,
    FoodComponent,
    EmployeeComponent,
    SalaryComponent,
    UserComponent,
    SampleComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(myRoutes),
    HttpClientModule
  ],
  providers: [MovieService,CustomerService,UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
