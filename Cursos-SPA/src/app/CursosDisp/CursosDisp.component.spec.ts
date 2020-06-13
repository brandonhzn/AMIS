/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CursosDispComponent } from './CursosDisp.component';

describe('CursosDispComponent', () => {
  let component: CursosDispComponent;
  let fixture: ComponentFixture<CursosDispComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CursosDispComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CursosDispComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
