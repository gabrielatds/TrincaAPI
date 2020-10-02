/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ChurrasComponent } from './churras.component';

describe('ChurrasComponent', () => {
  let component: ChurrasComponent;
  let fixture: ComponentFixture<ChurrasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChurrasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChurrasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
