import {Component} from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector:'app-employee',
    templateUrl:'./employee.component.html'
})
export class EmployeeComponent{
    constructor(private routes:Router){

    }


    showSalary(){
        this.routes.navigate(["/employee/salary"]);
    }
}