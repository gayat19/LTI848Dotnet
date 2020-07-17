import {Movie} from './movie';

export class MovieService{

    private movies:Movie[];

    constructor(){
     this.movies = [];
     var movie1,movie2;
    movie1 = new Movie();
    movie1.name="The A-Team";
    movie1.duration = 120.3;
    movie1.pic = "assets/images/Car.jpg";
    movie1.likeStatus = 2;
    movie2 = new Movie();
    movie2.name="Expendables";
    movie2.duration = 110.1;
    movie2.pic = "assets/images/Doll.jpg";
    movie2.likeStatus = 4;
    this.movies.push(movie1);
    this.movies.push(movie2);
    }

    //methodname:returntype{}
    getMovies():Movie[]{
        return this.movies;
    }

    addMovie(m:Movie){
        this.movies.push(m);
    }

}