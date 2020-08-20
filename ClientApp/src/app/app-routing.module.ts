import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home.component';
import {AddbookComponent} from './addbook/addbook.component' ;
import {BorrowComponent} from './borrow/borrow.component';
import {LoanedComponent} from './loaned/loaned.component' ;
import {ReturnComponent} from './return/return.component'

const routes: Routes = [{path : '' , component: HomeComponent},
{path : 'addbook', component: AddbookComponent},
{path : 'borrowbook', component: BorrowComponent},
{path : 'loanedbooks', component: LoanedComponent},
{path : 'returnbook', component: ReturnComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
