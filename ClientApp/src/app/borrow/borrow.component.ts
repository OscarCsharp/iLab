import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {BookService} from '../shared/book.service' ;

@Component({
  selector: 'app-borrow',
  templateUrl: './borrow.component.html',
  styleUrls: ['./borrow.component.css']
})
export class BorrowComponent implements OnInit {

  constructor(public service: BookService, public router: Router) { }
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
    this.service.bookForm.reset();

  }

  onSubmit() {
    this.service.booking().subscribe(
      (res: any) => {
        if (res) {
          this.service.bookForm.reset();
          this.router.navigate(['/']);
        }
      },
    );
  }



}
