import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mymenu',
  templateUrl: './mymenu.component.html',
  styleUrls: ['./mymenu.component.css']
})
export class MymenuComponent implements OnInit {

  username:string;
  qty:number;//2
  constructor() {
    this.username = "Ramu";
    this.qty=0;//3
   }

  ngOnInit(): void {
  }
  changeName(){
    this.username = "Something else";
  }
  //4
  incrQty(anyname){
    this.qty= anyname;
  }
}
