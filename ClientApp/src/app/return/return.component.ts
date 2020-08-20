import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {BookService} from '../shared/book.service' ;

@Component({
  selector: 'app-return',
  templateUrl: './return.component.html',
  styleUrls: ['./return.component.css']
})
export class ReturnComponent implements OnInit {

  constructor(public service: BookService, public router: Router) { }
  data ;

  ngOnInit() {
    this.service.getBooksLoanRecord().subscribe(
      res => {
        this.data = res;
      },
      err => {
        console.log(err);
      },
    );
    this.service.returnForm.reset();
  }

  onSubmit() {
    this.service.returning().subscribe(
      (res: any) => {
        if (res) {
          this.service.returnForm.reset();
          this.router.navigate(['/loanedbooks']);
        }
      },
    );
  }

}
