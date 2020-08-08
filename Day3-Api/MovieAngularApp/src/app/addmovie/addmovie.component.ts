import { Component, OnInit } from '@angular/core';
import { Movie } from '../models/movie';
import { MovieService } from '../services/movieService';

@Component({
  selector: 'app-addmovie',
  templateUrl: './addmovie.component.html',
  styleUrls: ['./addmovie.component.css']
})
export class AddmovieComponent implements OnInit {

  movie:Movie;
  result;
  constructor(private movieService:MovieService) {
    this.movie = new Movie();
   }
  insertMovie(){
    this.movieService.postMovie(this.movie).subscribe((data)=>{
      this.result = data;
    })
  }
  ngOnInit(): void {
  }

}
