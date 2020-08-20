import { Component, OnInit } from '@angular/core';
import {BookService} from '../shared/book.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private service: BookService) { }
  data ;

  ngOnInit() {

    this.service.getAvailablebooks().subscribe(
      res => {
        this.data = res;
      },
      err => {
        console.log(err);
      },
    );
  }

}
