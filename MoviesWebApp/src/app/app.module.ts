import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { MovieListComponent } from './movie-list/movie-list.component';
import { SelectedMovieComponent } from './selected-movie/selected-movie.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { MovieOperationService } from './services/MovieOperationService';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    MovieListComponent,
    SelectedMovieComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      {path:'get-movies', component: MovieListComponent}
    ])
  ],
  providers: [MovieOperationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
