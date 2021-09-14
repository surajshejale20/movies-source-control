import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-selected-movie',
  templateUrl: './selected-movie.component.html',
  styleUrls: ['./selected-movie.component.css']
})
export class SelectedMovieComponent implements OnInit {

  @Input() movie: any;
  @Output() backButtonClick: EventEmitter<boolean> = new EventEmitter();
  constructor() { }

  ngOnInit(): void {
  }

  goBack(){
    this.backButtonClick.emit(true)
  }

}
