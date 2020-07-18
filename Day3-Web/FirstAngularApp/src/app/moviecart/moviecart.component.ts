import { Component, OnInit } from '@angular/core';
import { MovieService } from '../movie/movie.service';
import { Movie } from '../movie/movie';

@Component({
  selector: 'app-moviecart',
  templateUrl: './moviecart.component.html',
  styleUrls: ['./moviecart.component.css']
})
export class MoviecartComponent implements OnInit {

  movieCart:Movie[];
  constructor(private movieService:MovieService) { 
    this.movieCart = this.movieService.getCart();
  }

  ngOnInit(): void {
  }

}
