import { Movie } from "../models/movie";
import {HttpClient} from '@angular/common/http';
import { Injectable } from "@angular/core";

@Injectable()
export class MovieService{

    movies:Movie[];
    constructor(private http:HttpClient){
        this.movies = [];
    }

    public getMovies(){
        return this.http.get("http://localhost:55596/api/Movies");
    }

    public postMovie(movie:Movie){
        return this.http.post("http://localhost:55596/api/Movies",movie);
    }
}