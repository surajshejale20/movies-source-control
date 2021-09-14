import { Component, OnInit } from '@angular/core';
import { MovieOperationService } from '../services/MovieOperationService';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  movieList: any;
  selectedMovie: any;
  showSelectedMovie = false;
  showMovieListFlag = true;

  constructor(private _movieOpsService: MovieOperationService) { }

  ngOnInit(): void {
    this._movieOpsService.getAllMovies().subscribe(result => {
      if(!!result){
        this.movieList = result;
      }
    });
  }

  movieSelection(movie: any){
    this.selectedMovie = movie;
    this.showMovieListFlag = false;
    this.showSelectedMovie = true;
  }

  displayList(e: any){
    this.showSelectedMovie = false;
    this.showMovieListFlag = true;
  }

}
