import { Component, OnInit } from '@angular/core';
import {BookService} from '../shared/book.service';

@Component({
  selector: 'app-loaned',
  templateUrl: './loaned.component.html',
  styleUrls: ['./loaned.component.css']
})
export class LoanedComponent implements OnInit {

  constructor(public service: BookService) { }
  data ;
  bookName ;

  ngOnInit() {
    this.service.getAllbookingrecords().subscribe(
      res => {
        this.data = res;
      },
      err => {
        console.log(err);
      },
    );

  }

}
