import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodsElementComponent } from './goods-element.component';

describe('GoodsElementComponent', () => {
  let component: GoodsElementComponent;
  let fixture: ComponentFixture<GoodsElementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodsElementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodsElementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
