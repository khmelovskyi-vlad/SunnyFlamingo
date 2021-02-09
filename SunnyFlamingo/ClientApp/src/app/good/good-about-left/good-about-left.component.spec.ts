import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodAboutLeftComponent } from './good-about-left.component';

describe('GoodAboutLeftComponent', () => {
  let component: GoodAboutLeftComponent;
  let fixture: ComponentFixture<GoodAboutLeftComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodAboutLeftComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodAboutLeftComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
