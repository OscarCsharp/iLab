import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoanedComponent } from './loaned.component';

describe('LoanedComponent', () => {
  let component: LoanedComponent;
  let fixture: ComponentFixture<LoanedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoanedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoanedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
