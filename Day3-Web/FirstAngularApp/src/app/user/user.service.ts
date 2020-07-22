import {HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';

import{Observable, throwError} from 'rxjs';


@Injectable()
export class UserService{
    constructor(private http:HttpClient){
    }

    getUserData(){
        return this.http.get("https://reqres.in/api/users");
        //post-Create
        //Put - Update
        //Delete - delete
    }


}