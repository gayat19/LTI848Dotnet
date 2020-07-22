import { Component, OnInit } from '@angular/core';
import { UserService } from './user.service';
import {User} from './user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  users:User[];
  constructor(private userService:UserService) { 
    this.users = [];
  }

  ngOnInit(): void {
  }
  showUsers(){
      this.userService.getUserData().subscribe((mydata)=>{
        //console.log(mydata['data']);
        this.users = mydata['data'];

      })
  }
}
