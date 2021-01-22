import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodsMainComponent } from './goods-main.component';

describe('GoodsMainComponent', () => {
  let component: GoodsMainComponent;
  let fixture: ComponentFixture<GoodsMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodsMainComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodsMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
