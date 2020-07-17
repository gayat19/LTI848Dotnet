import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-like',
  templateUrl: './like.component.html',
  styleUrls: ['./like.component.css']
})
export class LikeComponent implements OnInit {
  count:number;
  favStatus:boolean;
  likeClassName;
  constructor() { 
    this.count = 0;
    this.favStatus=true;
    this.likeClassName = "glyphicon glyphicon-heart";
  }

  ngOnInit(): void {
  }
  likeCount(){
      this.count++;
  }
  unLikeCount(){
    this.count--;
  }
  favChange(){
    this.favStatus = !this.favStatus;
  }
  favChangeAnother(){
    this.favStatus = !this.favStatus;
    if(this.favStatus)
    this.likeClassName = "glyphicon glyphicon-heart";
    else
    this.likeClassName = "glyphicon glyphicon-heart-empty";
  }
}
