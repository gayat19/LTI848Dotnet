import { Component, OnInit } from '@angular/core';
import {Movie} from './movie';
import {MovieService} from './movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {
movieName:string;
movie:Movie;
movies:Movie[];
movieSer:MovieService;
showToggle:boolean;
  constructor() { 
    this.movie = new Movie();
    this.movieSer = new MovieService();
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
    this.showToggle = false;
  }
}
