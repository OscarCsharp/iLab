import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {BookService} from '../shared/book.service' ;
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-addbook',
  templateUrl: './addbook.component.html',
  styleUrls: ['./addbook.component.css']
})
export class AddbookComponent implements OnInit {

  constructor(public service: BookService, private toastr: ToastrService, public router: Router) { }

  ngOnInit() {
    this.service.formModel.reset();
  }


  onSubmit() {
    this.service.adding().subscribe(
      (res: any) => {
        if (res) {
          this.service.formModel.reset();
          this.toastr.success('New Book', 'The Book is successfully added ');
        }
      },
    );
  }


}
