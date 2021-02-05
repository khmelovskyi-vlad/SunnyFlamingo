import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodMainComponent } from './good-main.component';

describe('GoodMainComponent', () => {
  let component: GoodMainComponent;
  let fixture: ComponentFixture<GoodMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodMainComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
