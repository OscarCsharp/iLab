import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AddbookComponent } from './addbook/addbook.component';
import { NavbarComponent } from './navbar/navbar.component';

import { HttpClientModule} from '@angular/common/http';
import {BookService} from './shared/book.service' ;
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BorrowComponent } from './borrow/borrow.component';
import { LoanedComponent } from './loaned/loaned.component';
import { ReturnComponent } from './return/return.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddbookComponent,
    NavbarComponent,
    BorrowComponent,
    LoanedComponent,
    ReturnComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    BsDatepickerModule.forRoot(),
    ToastrModule.forRoot({
      progressBar: true
    }),

  ],
  providers: [BookService],
  bootstrap: [AppComponent]
})
export class AppModule { }
