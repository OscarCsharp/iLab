import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private fb: FormBuilder,  private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:5000/api';

  formModel = this.fb.group({
    Title : ['', Validators.required],
    Author : ['', Validators.required],
    Description : ['', Validators.required],
    Year : ['', Validators.required]
  });


  bookForm = this.fb.group({
    BookId : ['', Validators.required],
    CurrentOwner : ['', Validators.required],
    CellNo : ['', Validators.required],
    Email : ['', Validators.email],
    RequestedDate : ['', Validators.required],
    ReturnDate : ['', Validators.required]
  });



  returnForm = this.fb.group({
    BookId : ['', Validators.required],
    ReturnedOn : ['', Validators.required],
    ReturnedBy : ['', Validators.required]
  });

  adding() {
    var body = {
      Title: this.formModel.value.Title,
      Author: this.formModel.value.Author,
      Description: this.formModel.value.Description,
      Year: this.formModel.value.Year,
    };
    return this.http.post(this.BaseURI + '/books', body);
  }


  booking() {
    var body = {
      BookId: this.bookForm.value.BookId,
      CurrentOwner: this.bookForm.value.CurrentOwner,
      CellNo: this.bookForm.value.CellNo,
      Email: this.bookForm.value.Email,
      RequestedDate: this.bookForm.value.RequestedDate,
      ReturnDate: this.bookForm.value.ReturnDate,

    };
    return this.http.post(this.BaseURI + '/bookingrecords', body);
  }

  returning() {
    var body = {
      BookId : this.returnForm.value.BookId,
      ReturnedOn: this.returnForm.value.ReturnedOn,
      ReturnedBy: this.returnForm.value.ReturnedBy

    };
    return this.http.post(this.BaseURI + '/bookingrecords/returnbook', body);
  }
  getBooks() {
    return this.http.get(this.BaseURI + '/books');
  }

  getAvailablebooks() {
    return this.http.get(this.BaseURI + '/books/getavailablebooks');
  }

  getBooksLoanRecord() {
    return this.http.get(this.BaseURI + '/books/getloanedbooks');
  }

  getAllbookingrecords() {
    return this.http.get(this.BaseURI + '/bookingrecords');
  }



}
