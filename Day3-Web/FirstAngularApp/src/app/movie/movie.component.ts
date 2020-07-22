import { Component, OnInit } from '@angular/core';
import {Movie} from './movie';
import {MovieService} from './movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styles:[`section{
    height: 200px;
    width: 200px;
}`]
})
export class MovieComponent implements OnInit {
movieName:string;
movie:Movie;
movies:Movie[];
//movieSer:MovieService;
showToggle:boolean;
  constructor(private movieSer:MovieService) { 
    this.movie = new Movie();
    //this.movieSer = new MovieService();
    this.movies = this.movieSer.getMovies();
    this.showToggle = true;
  }

  ngOnInit(): void {
  }
  incrLikes(){
    this.movie.likeStatus++;
  }
  displayDetails(){
    this.movieSer.addMovie(this.movie);
    this.movie = new Movie();
    this.showToggle = false;
  }
}
