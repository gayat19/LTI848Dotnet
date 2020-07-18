import {Movie} from './movie';

export class MovieService{

    private movies:Movie[];
    private cart:Movie[];

    constructor(){
     this.movies = [];
     this.cart = [];
     var movie1,movie2;
    movie1 = new Movie();
    movie1.name="The A-Team";
    movie1.duration = 120.3;
    movie1.pic = "assets/images/Car.jpg";
    movie1.likeStatus = 2;
    movie1.count = 3;
    movie2 = new Movie();
    movie2.name="Expendables";
    movie2.duration = 110.1;
    movie2.pic = "assets/images/Doll.jpg";
    movie2.likeStatus = 4;
    movie2.count = 3;
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
    getCart(){
        return this.cart;
    }
    addToCart(m:Movie)
    {
        var present:Boolean = false; 
        for (let index = 0; index < this.movies.length; index++) {
            if(this.movies[index].name ==m.name)
                {
                    this.movies[index].count--;
                    for (let i = 0; i < this.cart.length; i++) {
                        if(m.name == this.cart[i].name)
                        {
                            this.cart[i].count++;
                            present = true;
                            break;
                        }
                    }
                    if(present==false)
                    {
                        var movie:Movie;
                        movie = new Movie();
                        movie.name = m.name;
                        movie.count = 1;
                        this.cart.push(movie)
                        console.log(movie);
                    }
                  break;
                }
        }
    }

}