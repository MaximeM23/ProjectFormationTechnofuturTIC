/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { FacturingAddressComponent } from './Facturing-Address.component';

describe('FacturingAddressComponent', () => {
  let component: FacturingAddressComponent;
  let fixture: ComponentFixture<FacturingAddressComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FacturingAddressComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FacturingAddressComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
