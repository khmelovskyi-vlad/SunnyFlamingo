import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodAboutTopComponent } from './good-about-top.component';

describe('GoodAboutTopComponent', () => {
  let component: GoodAboutTopComponent;
  let fixture: ComponentFixture<GoodAboutTopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodAboutTopComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodAboutTopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
